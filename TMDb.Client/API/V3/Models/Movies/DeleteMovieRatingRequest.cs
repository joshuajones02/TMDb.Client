﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Movies
{
    /// <summary>
    /// Remove your rating for a movie.
    /// A valid session or guest session ID is required. You can read more about how this works here.
    /// https://developers.themoviedb.org/3/authentication/how-do-i-generate-a-session-id
    /// </summary>
    [ApiDeleteEndpoint("/movie/{movie_id}/rating")]
    public class DeleteMovieRatingRequest : MovieBaseRequest
    {
        /// <summary>
        ///     default: application/json;charset=utf-8
        /// </summary>
        [ApiParameter(
            Name = "Content-Type",
            ParameterType = ParameterType.Header)]
        [Required]
        public virtual string ContentType { get; set; }

        [ApiParameter(
            Name = "guest_session_id",
            ParameterType = ParameterType.Query)]
        public virtual string GuestSessionId { get; set; }

        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.Query)]
        public virtual string SessionId { get; set; }
    }
}
