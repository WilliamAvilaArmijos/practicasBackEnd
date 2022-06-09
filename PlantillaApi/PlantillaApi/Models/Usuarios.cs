

using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PlantillaApi.Models
{
    public class Usuarios
    { 
        [Key]
        public int Ci { get; set; }
        public string? Nombres { get; set; }
        public string? Usuario { get; set; }
        public string? Clave { get; set; }


    }
}
