using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.ComponentModel.DataAnnotations;

namespace AUT02_02_HernandezToledoJorge_ModernFamily.Models
{
    public class Personaje
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int NChildren { get; set; }
    }


}
