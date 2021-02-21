﻿using Entities.Abstract;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
    }
}