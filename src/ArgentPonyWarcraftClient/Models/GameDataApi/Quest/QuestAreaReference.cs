﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a quest area.
    /// </summary>
    public class QuestAreaReference
    {
        /// <summary>
        /// Gets the key for the quest area.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the quest area.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the quest area.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
