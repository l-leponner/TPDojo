using System.ComponentModel.DataAnnotations;

namespace BO
{
    public class Arme
    {
        public int Id { get; set; }
        [DisplayFormat(NullDisplayText = "[Pas d'arme]", ApplyFormatInEditMode = true)]
        public string Nom { get; set; }
        public int Degats { get; set; }
    }
}