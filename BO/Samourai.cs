using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Samourai : Entite
    {
        public int Force { get; set; }
        
        public Arme? Arme { get; set; }

        public List<ArtMartial>? ArtsMartiaux { get; set; }

        public int Potentiel { get
            {
                int p = Force;
                if(Arme != null)
                {
                    p += Arme.Degats;
                }
                if(ArtsMartiaux != null)
                {
                    p *= (1 + ArtsMartiaux.Count());
                }
                return p;
            }
                }
    }
}
