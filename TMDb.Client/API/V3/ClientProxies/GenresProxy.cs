﻿using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Genres;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class GenresProxy : ApiProxy
    {
        public GenresProxy(TMDbClient client) : base(client)
        {
        }

        public Task<GenresResponse> ListMovieGenres(GenresRequest request) =>
            Client.GetAsync<GenresResponse>(Serialize("/genre/movie/list", request));

        public Task<GenresResponse> TV(GenresRequest request) =>
            Client.GetAsync<GenresResponse>(Serialize("/genre/tv/list", request));
    }
}