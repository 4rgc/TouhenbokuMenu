using System;
using System.Collections.Generic;

namespace Menu.Models
{
    public partial class Noodles
    {
        public Noodles()
        {
            Ramen = new HashSet<Ramen>();
        }

        public long NoodleId { get; set; }
        public string NoodleName { get; set; }

        public virtual ICollection<Ramen> Ramen { get; set; }
    }
}
