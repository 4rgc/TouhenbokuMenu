using System;
using System.Collections.Generic;

namespace Menu.Models
{
    public partial class Drinks
    {
        public long DrinkId { get; set; }
        public string DrinkName { get; set; }
        public byte[] DrinkIsCombo { get; set; }
        public long? DrinkPrice { get; set; }
    }
}
