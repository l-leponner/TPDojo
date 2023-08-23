using BO;
using MessagePack;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TPDojo.Models
{
    public class SamouraisVM
    {
        //[IgnoreMember]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public int Force { get; set; }
        [DisplayName("Arme")]
        public int? ArmeId { get; set; }
        public SelectList SelectArmes { get; set; }
        [DisplayName("Arts Martiaux")]
        public List<int> ArtsMartiauxIds { get; set; }
        public MultiSelectList SelectArtsMartiaux { get; set; }
    }
}
