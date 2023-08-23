using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Samourai : DojoBaseAttributes
    {
        public int Force { get; set; }
        
        public Arme? Arme { get; set; }

        public List<ArtMartial>? ArtsMartiaux { get; set; }
    }
}
