﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a realm.
    /// </summary>
    public class RealmReferenceWithoutName
    {
        /// <summary>
        /// Gets the key for the realm.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the realm.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets a slug for the realm.
        /// </summary>
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
    }
}
