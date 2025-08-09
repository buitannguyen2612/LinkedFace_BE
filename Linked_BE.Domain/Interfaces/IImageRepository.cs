using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Linked_BE.Domain.Entities;

namespace Linked_BE.Domain.Interfaces
{
    public interface IImageRepository
    {
        Task CreateImageAsync(Images image);
    }
}