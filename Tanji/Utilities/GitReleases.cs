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

using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Tanji.Utilities
{
    [CollectionDataContract]
    public class GitReleases : List<GitRelease>
    {
        private static readonly HttpClient _httpClient;
        private static readonly HttpClientHandler _httpClientHandler;
        private static readonly DataContractJsonSerializer _deserializer;

        static GitReleases()
        {
            _deserializer = new DataContractJsonSerializer(typeof(GitReleases));

            _httpClientHandler = new HttpClientHandler() { UseProxy = false };
            _httpClient = new HttpClient(_httpClientHandler, true) { Timeout = TimeSpan.FromSeconds(10) };

            _httpClient.DefaultRequestHeaders.Add("User-Agent",
                    "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident / 6.0)");
        }

        public static async Task<string> ToHTMLAsync(GitRelease release)
        {
            var content = new StringContent(
                release.Body, Encoding.UTF8, "text/plain");

            var releaseJson = await _httpClient.PostAsync(
                "https://api.github.com/markdown/raw", content).ConfigureAwait(false);

            return await releaseJson.Content
                .ReadAsStringAsync().ConfigureAwait(false);
        }
        public static async Task<GitReleases> CreateAsync(string owner, string repository)
        {
            string releaseJson = await _httpClient.GetStringAsync(
                $"https://api.github.com/repos/{owner}/{repository}/releases")
                .ConfigureAwait(false);

            byte[] rawJson = Encoding.UTF8.GetBytes(releaseJson);
            using (var jsonStream = new MemoryStream(rawJson))
                return (GitReleases)_deserializer.ReadObject(jsonStream);
        }
    }
}