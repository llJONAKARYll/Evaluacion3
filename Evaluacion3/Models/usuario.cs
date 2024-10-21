﻿using System.ComponentModel.DataAnnotations;

namespace Evaluacion3.Models
{
    public class usuario
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Rol { get; set; }

        [Required]
        public string Email { get; set; }

        public int MaxHerramientasEnUso { get; set; } = 3;
    }
}
