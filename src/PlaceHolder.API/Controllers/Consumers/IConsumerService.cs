﻿using System.Threading.Tasks;

namespace PlaceHolder.API.Controllers.Consumers
{
    public interface IConsumerService
    {
        Task<ConsumerDto> CreateConsumerAsync(ConsumerDto consumerDto);
        Task<ConsumerDto> UpdateConsumerAsync(ConsumerDto consumerDto);
        Task<ConsumerDto> GetOneByIdAsync(string guid);
    }
}
