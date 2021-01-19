﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDb.Client.Entities.Media;
using TMDb.Client.Entities.Organizations;
using TMDb.Client.Entities.Things;

namespace TMDb.Client.API.V3.Models.TV
{
    public class LatestTVResponse
    {
        [JsonProperty("in_production")]
        public virtual bool InProduction { get; set; }

        [JsonProperty("popularity")]
        public virtual double Popularity { get; set; }

        [JsonProperty("number_of_episodes")]
        public virtual int NumberOfEpisodes { get; set; }

        [JsonProperty("number_of_seasons")]
        public virtual int NumberOfSeasons { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("vote_average")]
        public virtual int VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public virtual int VoteCount { get; set; }

        [JsonProperty("poster_path")]
        public virtual object PosterPath { get; set; }

        [JsonProperty("next_episode_to_air")]
        public virtual object NextEpisodeToAir { get; set; }

        [JsonProperty("backdrop_path")]
        public virtual object BackdropPath { get; set; }

        [JsonProperty("homepage")]
        public virtual string Homepage { get; set; }

        [JsonProperty("original_language")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("original_name")]
        public virtual string OriginalName { get; set; }

        [JsonProperty("overview")]
        public virtual string Overview { get; set; }

        [JsonProperty("status")]
        public virtual string Status { get; set; }

        [JsonProperty("tagline")]
        public virtual string Tagline { get; set; }

        [JsonProperty("type")]
        public virtual string Type { get; set; }

        [JsonProperty("first_air_date")]
        public virtual DateTime? FirstAirDate { get; set; }

        [JsonProperty("last_air_date")]
        public virtual DateTime? LastAirDate { get; set; }

        [JsonProperty("last_episode_to_air")]
        public virtual Episode LastEpisodeToAir { get; set; }

        [JsonProperty("created_by")]
        public virtual IEnumerable<TVCreatedBy> CreatedBy { get; set; }

        [JsonProperty("episode_run_time")]
        public virtual IEnumerable<int> EpisodeRunTime { get; set; }

        [JsonProperty("genres")]
        public virtual IEnumerable<MovieGenre> Genres { get; set; }

        [JsonProperty("languages")]
        public virtual IEnumerable<string> LanguageAbbreviations { get; set; }

        [JsonProperty("networks")]
        public virtual IEnumerable<Network> Networks { get; set; }

        [JsonProperty("production_companies")]
        public virtual IEnumerable<ProductionCompany> ProductionCompanies { get; set; }

        [JsonProperty("origin_country")]
        public virtual IEnumerable<string> CountryAbbreviations { get; set; }

        [JsonProperty("production_countries")]
        public virtual IEnumerable<ProductionCountry> ProductionCountries { get; set; }

        [JsonProperty("seasons")]
        public virtual IEnumerable<Season> Seasons { get; set; }

        [JsonProperty("spoken_languages")]
        public virtual IEnumerable<Language> SpokenLanguages { get; set; }
    }
}