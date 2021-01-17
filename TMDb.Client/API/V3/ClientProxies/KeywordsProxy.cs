﻿using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Keywords;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class KeywordsProxy : ApiProxy
    {
        public KeywordsProxy(TMDbClient client) : base(client)
        {
        }

        public string FormatPath(string path, int id) =>
            string.Format(path, id);

        public Task<KeywordDetailsResponse> GetAsync(KeywordDetailsRequest request) =>
            Client.GetAsync<KeywordDetailsResponse>(
                Serialize(FormatPath("/keyword/{0}", request.KeywordId), request));

        public Task<KeywordMovieResponse> GetAsync(KeywordMovieRequest request) =>
            Client.GetAsync<KeywordMovieResponse>(
                Serialize(FormatPath("/keyword/{0}/movies", request.KeywordId), request));
    }
}