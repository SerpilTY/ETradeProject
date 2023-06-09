﻿
using ETradeAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeAPI.Persistance.Concretes
{
    public class ProductService 
    {
        public List<Product> GetProducts()
        => new()
        {
            new() { Id=Guid.NewGuid(),Name=" Product 1",Price=100,Stock=10 },
            new() { Id=Guid.NewGuid(),Name=" Product 2",Price=100,Stock=10 },
            new() { Id=Guid.NewGuid(),Name=" Product 3",Price=100,Stock=10 },
            new() { Id=Guid.NewGuid(),Name=" Product 4",Price=100,Stock=10 },
            new() { Id=Guid.NewGuid(),Name=" Product 5",Price=100,Stock=10 }
        };
    }
}
