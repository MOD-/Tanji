/* Copyright

    GitHub(Source): https://GitHub.com/ArachisH/Tanji

    Habbo Hotel Packet(Logger/Manipulator)
    Copyright (C) 2015 ArachisH

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.

    See License.txt in the project root for license information.
*/

using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System;

namespace Tanji.Utilities
{
    [DataContract]
    public class GitReleases : IReadOnlyList<GitRelease>
    {
        [DataMember(Name = "releases")]
        private List<GitRelease> _releases { get; set; } = new List<GitRelease>();

        private static readonly HttpClient _httpClient;
        private static readonly HttpClientHandler _httpClientHandler;
        private static readonly DataContractJsonSerializer _deserializer;

        public int Count => _releases.Count;
        public GitRelease this[int index] => _releases[index];

        public IEnumerator<GitRelease> GetEnumerator() =>
            _releases.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() =>
            ((IEnumerable)_releases).GetEnumerator();

        static GitReleases()
        {
            _deserializer = new DataContractJsonSerializer(typeof(GitReleases));

            _httpClientHandler = new HttpClientHandler() { UseProxy = false };
            _httpClient = new HttpClient(_httpClientHandler, true);

            _httpClient.DefaultRequestHeaders.Add("User-Agent",
                "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident / 6.0)");
        }

        public static async Task<string> RenderBodyToHTML(GitRelease release)
        {
            var content = new StringContent(release.Body,
                Encoding.UTF8, "text/plain");

            var releaseJson = await _httpClient.PostAsync(
                "https://api.github.com/markdown/raw", content).ConfigureAwait(false);

            return await releaseJson.Content.ReadAsStringAsync();
        }
        public static async Task<GitReleases> CreateAsync(string owner, string repository)
        {
            string releaseJson = await _httpClient.GetStringAsync(
                $"https://api.github.com/repos/{owner}/{repository}/releases").ConfigureAwait(false);
            releaseJson = $"{{\"releases\":[{releaseJson.Substring(1, releaseJson.Length - 2)}]}}";

            byte[] rawJson = Encoding.UTF8.GetBytes(releaseJson);
            using (var jsonStream = new MemoryStream(rawJson))
            {
                return (GitReleases)_deserializer.ReadObject(jsonStream);
            }
        }
    }
}