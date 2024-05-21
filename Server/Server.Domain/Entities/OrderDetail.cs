﻿using Server.Domain.Abstractions;

namespace Server.Domain.Entities
{
    public sealed class OrderDetail : Entity
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal Vat { get; set; }
        public bool VatInclude { get; set; }
    }
}
