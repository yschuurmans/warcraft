﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of the mounts a character has obtained.
    /// </summary>
    public class CharacterMountsCollectionSummary
    {
        /// <summary>
        /// Gets links for the character mounts collection summary.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the mounts this character has collected.
        /// </summary>
        [JsonPropertyName("mounts")]
        public CharacterMount[] Mounts { get; set; }
    }
}
