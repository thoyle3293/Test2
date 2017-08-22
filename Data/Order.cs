using System;
using System.Collections.Generic;

namespace Test2.Data
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}
