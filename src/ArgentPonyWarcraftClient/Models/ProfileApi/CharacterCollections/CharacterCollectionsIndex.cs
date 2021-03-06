﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of character collections.
    /// </summary>
    public class CharacterCollectionsIndex
    {
        /// <summary>
        /// Gets links for the character collections index.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the character's collection of pets.
        /// </summary>
        [JsonPropertyName("pets")]
        public Self Pets { get; set; }

        /// <summary>
        /// Gets a reference to the character's collection of mounts.
        /// </summary>
        [JsonPropertyName("mounts")]
        public Self Mounts { get; set; }
    }
}
