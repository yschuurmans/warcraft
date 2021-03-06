﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// PvP season match statistics.
    /// </summary>
    public class SeasonMatchStatistics
    {
        /// <summary>
        /// Gets the number of matches played.
        /// </summary>
        [JsonPropertyName("played")]
        public int Played { get; set; }

        /// <summary>
        /// Gets the number of matches won.
        /// </summary>
        [JsonPropertyName("won")]
        public int Won { get; set; }

        /// <summary>
        /// Gets the number of matches lost.
        /// </summary>
        [JsonPropertyName("lost")]
        public int Lost { get; set; }
    }
}
