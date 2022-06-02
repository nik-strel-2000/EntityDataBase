using System;
using System.Collections.Generic;

namespace TestirovanieNik.Models
{
    public partial class OrderProduct
    {
        public int IdOrderProduct { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public string? AddressName { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
