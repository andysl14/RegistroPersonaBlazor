using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPersona.Models
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }
        [Required(ErrorMessage ="El campo nombres esta vacio ")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "El campo Telefono esta vacio ")] 
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El campo Cedula esta vacio ")] 
        public string Cedula { get; set; }
        [Required(ErrorMessage = "Este campo Direccion no puede estar vacio.")] 
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El campo fecha esta vacio")]
        public DateTime Fecha { get; set; } = DateTime.Now;

    }
}
