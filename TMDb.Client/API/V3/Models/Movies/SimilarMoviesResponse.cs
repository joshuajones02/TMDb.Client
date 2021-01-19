﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TMDb.Client.Attributes;
using TMDb.Client.Entities.Media;

namespace TMDb.Client.API.V3.Models.Movies
{
    public class SimilarMoviesResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<MovieMinified> Results { get; set; }
    }
}
