﻿using Newtonsoft.Json;
using System;

namespace WeatherAPI.NET.Entities
{
    public class AstroEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the moon illumination, as a percentage (0-100%).
        /// </summary>
        [JsonProperty("moon_illumination")]
        public int MoonIllumination { get; set; }

        /// <summary>
        /// Gets or sets the moon phase.
        /// </summary>
        [JsonProperty("moon_phase")]
        public string MoonPhase { get; set; }

        /// <summary>
        /// Gets or sets the moonrise time.
        /// </summary>
        [JsonProperty("moonrise")]
        public string Moonrise { get; set; }

        /// <summary>
        /// Gets or sets the moonset time.
        /// </summary>
        [JsonProperty("moonset")]
        public string Moonset { get; set; }

        /// <summary>
        /// Gets or sets the sunrise time.
        /// </summary>
        [JsonProperty("sunrise")]
        public string Sunrise { get; set; }

        /// <summary>
        /// Gets or sets the sunset time.
        /// </summary>
        [JsonProperty("sunset")]
        public string Sunset { get; set; }

        public DateTime MoonriseTime => Convert.ToDateTime(Moonrise);

        public DateTime MoonsetTime => Convert.ToDateTime(Moonset);

        public DateTime SunriseTime => Convert.ToDateTime(Sunrise);

        public DateTime SunsetTime => Convert.ToDateTime(Sunset);

        #endregion
    }
}
