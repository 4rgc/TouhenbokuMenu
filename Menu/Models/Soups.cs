using System;
using System.Collections.Generic;

namespace Menu.Models
{
    public partial class Soups
    {
        public Soups()
        {
            Ramen = new HashSet<Ramen>();
        }

        public long SoupId { get; set; }
        public string SoupName { get; set; }

        public virtual ICollection<Ramen> Ramen { get; set; }
    }
}
