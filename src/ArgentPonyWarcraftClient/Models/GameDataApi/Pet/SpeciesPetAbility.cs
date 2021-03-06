﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A pet ability for a specific pet species.
    /// </summary>
    public class SpeciesPetAbility
    {
        /// <summary>
        /// Gets a reference to the pet ability.
        /// </summary>
        [JsonPropertyName("ability")]
        public PetAbilityReference Ability { get; set; }

        /// <summary>
        /// Gets the slot number for the pet ability.
        /// </summary>
        [JsonPropertyName("slot")]
        public int Slot { get; set; }

        /// <summary>
        /// Gets the required pet level to use the pet ability.
        /// </summary>
        [JsonPropertyName("required_level")]
        public int RequiredLevel { get; set; }
    }
}
