using System;
using System.Collections.Generic;

namespace TestirovanieNik.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public int IdProduct { get; set; }
        public string NameProduct { get; set; } = null!;
        public string Price { get; set; } = null!;
        public int TypeId { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
