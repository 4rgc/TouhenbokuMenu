using System;
using System.Collections.Generic;

namespace Menu.Models
{
    public partial class Ramen
    {
        public long RamenId { get; set; }
        public string RamenName { get; set; }
        public byte[] RamenIsPreset { get; set; }
        public long? RamenSoup { get; set; }
        public long? RamenSeasoning { get; set; }
        public long? RamenNoodle { get; set; }
        public long? RamenMeat { get; set; }
        public long RamenPrice { get; set; }
        public byte[] RamenIsVeggie { get; set; }

        public virtual Meats RamenMeatNavigation { get; set; }
        public virtual Noodles RamenNoodleNavigation { get; set; }
        public virtual Seasonings RamenSeasoningNavigation { get; set; }
        public virtual Soups RamenSoupNavigation { get; set; }
    }
}
