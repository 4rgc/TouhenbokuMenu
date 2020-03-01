using System;
using System.Collections.Generic;

namespace Menu.Models
{
    public partial class Appetizers
    {
        public long AppetizerId { get; set; }
        public string AppetizerName { get; set; }
        public byte[] AppetizerIsCombo { get; set; }
        public long? AppetizerPrice { get; set; }
    }
}
