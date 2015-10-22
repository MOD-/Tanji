/*
    GitHub(Source): https://GitHub.com/ArachisH/Tanji

    This file is part of Tanji.
    Copyright (C) 2015 ArachisH
    
    This code is licensed under the GNU General Public License.
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