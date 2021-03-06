﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of game expansions.
    /// </summary>
    public class JournalExpansionsIndex
    {
        /// <summary>
        /// Gets links for the index of game expansions.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the tiers of content for the game expansions.
        /// </summary>
        [JsonPropertyName("tiers")]
        public Tier[] Tiers { get; set; }
    }
}
