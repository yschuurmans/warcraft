﻿using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class PetApiTests
    {
        [ResilientFact]
        public async Task GetPetsIndexAsync_Gets_PetsIndex()
        {
            IPetApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PetsIndex> result = await warcraftClient.GetPetsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetPetAsync_Gets_Pet()
        {
            IPetApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<Pet> result = await warcraftClient.GetPetAsync(39, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetPetAbilitiesIndexAsync_Gets_PetAbilitiesIndex()
        {
            IPetApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PetAbilitiesIndex> result = await warcraftClient.GetPetAbilitiesIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetPetAbilityAsync_Gets_PetAbility()
        {
            IPetApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PetAbility> result = await warcraftClient.GetPetAbilityAsync(110, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetPetAbilityMediaAsync_Gets_PetAbilityMedia()
        {
            IPetApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PetAbilityMedia> result = await warcraftClient.GetPetAbilityMediaAsync(110, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
