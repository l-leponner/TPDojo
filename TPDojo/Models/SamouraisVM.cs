using BO;
using MessagePack;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public int? ArmeId { get; set; }
        public SelectList SelectArmes { get; set; }
    }
}
