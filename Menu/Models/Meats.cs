using System;
using System.Collections.Generic;

namespace Menu.Models
{
    public partial class Meats
    {
        public Meats()
        {
            Ramen = new HashSet<Ramen>();
        }

        public long MeatId { get; set; }
        public string MeatName { get; set; }

        public virtual ICollection<Ramen> Ramen { get; set; }
    }
}
