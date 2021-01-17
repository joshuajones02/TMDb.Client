﻿using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.TVEpisodes
{
    public class TVEpisodesDeleteRatingRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "guest_session_id")]
        public virtual string GuestSessionId { get; set; }

        [ApiParameter(
            Name = "session_id")]
        public virtual string SessionId { get; set; }

        // TODO: Add implementation - this is a header property
        [JsonIgnore]
        [ApiParameter(
            Name = "Content-Type")]
        public virtual string ContentType { get; set; }
    }
}