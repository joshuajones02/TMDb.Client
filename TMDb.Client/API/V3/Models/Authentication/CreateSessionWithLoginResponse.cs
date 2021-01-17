﻿using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Authentication
{
    public class CreateSessionWithLoginResponse : AuthenticationResponse
    {
        [JsonProperty("request_token")]
        public string RequestToken { get; set; }
    }
}