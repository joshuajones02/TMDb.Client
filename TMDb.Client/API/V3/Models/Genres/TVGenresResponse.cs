﻿using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Things;

namespace TMDb.Client.Api.V3.Models.Genres
{
    public class TVGenresResponse : TMDbResponse
    {
        [JsonProperty("genres")]
        public virtual IEnumerable<Genre> Genres { get; set; }
    }
}