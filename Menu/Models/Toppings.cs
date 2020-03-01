using System;
using System.Collections.Generic;

namespace Menu.Models
{
    public partial class Toppings
    {
        public long ToppingId { get; set; }
        public string ToppingName { get; set; }
        public long? ToppingPrice { get; set; }
    }
}
