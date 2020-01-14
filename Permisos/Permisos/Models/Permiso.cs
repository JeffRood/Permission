using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Permisos.Models
{
    public class Permiso
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NombreEmpleado { get; set; }
        [Required]
        public string ApellidosEmpleado { get; set; }
        [Required]
        public int TipoPermiso { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
    }

}
