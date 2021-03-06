﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of a character's reputations.
    /// </summary>
    public class CharacterReputationsSummary
    {
        /// <summary>
        /// Gets links for the summary of the character's reputations.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Gets 
        /// </summary>
        [JsonPropertyName("reputations")]
        public Reputation[] Reputations { get; set; }
    }
}
