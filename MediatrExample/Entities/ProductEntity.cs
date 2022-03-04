using System;

namespace MediatrExample.Entities
{
    public class ProductEntity
    {
        public Guid guid { get; set; }
        public String Name { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}
