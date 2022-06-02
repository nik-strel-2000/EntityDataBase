using System;
using System.Collections.Generic;

namespace TestirovanieNik.Models
{
    public partial class ProductFull
    {
      
        public int IdProduct { get; set; }
        public string NameProduct { get; set; } = null!;
        public string Price { get; set; } = null!;
        public string TypeName{ get; set; }

        
    }
}
