using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FBUsuarios.Models
{
    public class Usuarios
    {
        public int Id { get; set; }

        [Required]
        public string nombres { get; set; }
        
        [Required]
        public string apellidos { get; set; }

        [Required]
        public string correo { get; set; }

        [Required]
        public int rol { get; set; }

        [Required]
        public DateTime fechanacimiento { get; set; }

        public int edad { get; set; }

    }
}
