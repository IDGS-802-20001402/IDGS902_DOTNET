//model alumno con los campos id, nombre, email, edad

using System;
using System.ComponentModel.DataAnnotations;

namespace ApiAlumnos.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [Range(18, 99)]
        public int Edad { get; set; }
    }
}