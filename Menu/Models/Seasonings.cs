using System;
using System.Collections.Generic;

namespace Menu.Models
{
    public partial class Seasonings
    {
        public Seasonings()
        {
            Ramen = new HashSet<Ramen>();
        }

        public long SeasoningId { get; set; }
        public string SeasoningName { get; set; }

        public virtual ICollection<Ramen> Ramen { get; set; }
    }
}
