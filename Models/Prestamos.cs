using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPersona.Models
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        [Required(ErrorMessage = "El campo PersonaId es obligatorio")]
        public int PersonaId { get; set; }
        [Required(ErrorMessage = "El Campo concepto esta vacio")]
        public string Concepto { get; set; }
        [Required(ErrorMessage = "El campo monto esta vacio"), Range(minimum: 1, maximum: 20000000, ErrorMessage = "Debe tener un minimo de 1 y máximo de 2,000,000")]
        public double Monto { get; set; }
        [Required(ErrorMessage = "El campo fecha es obligatorio")]
        public DateTime Fecha { get; set; } = DateTime.Now;
        public double Balance { get; set; }
    }

}
