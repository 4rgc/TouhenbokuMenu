using System;
using System.Collections.Generic;

namespace Menu.Models
{
    public partial class Desserts
    {
        public long DessertId { get; set; }
        public string DessertName { get; set; }
        public long? DessertPrice { get; set; }
    }
}
