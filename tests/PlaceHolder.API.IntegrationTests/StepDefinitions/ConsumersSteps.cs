﻿using BoDi;
using PlaceHolder.API.Controllers.Consumers.Dtos;
using PlaceHolder.API.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace PlaceHolder.API.IntegrationTests.StepDefinitions
{
    [Binding, Scope(Feature ="Consumers")]
    public class ConsumersSteps
    {
        private IObjectContainer _container;
        private AddressDto _addressDto;
        private ConsumerDto _consumerDto;

        public ConsumersSteps(IObjectContainer container) => _container = container;

        [Given(@"the following AddressDto")]
        public void GivenTheFollowingAddressDto(Table table)
        {
            _addressDto = table.CreateInstance<AddressDto>();
        }

        [Given(@"the following ConsumerDto")]
        public void GivenTheFollowingConsumerDTO(Table table)
        {
            _consumerDto = table.CreateInstance<ConsumerDto>();
            _consumerDto.Address = _addressDto;
        }

        [Then(@"I Get the following ConsumerDto")]
        public async Task ThenIGetTheFollowingData(Table table)
        {
            var dto = table.CreateInstance<ConsumerDto>();
            await _container.Resolve<TestResultTracker>().AssertData(dto);
        }
    }
}
