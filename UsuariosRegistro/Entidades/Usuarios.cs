﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosRegistro.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public int NivelUsuario { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Usuarios()
        {
            this.UsuarioId = 0;
            this.Nombres = string.Empty;
            this.Email = string.Empty;
            this.NivelUsuario = 0;
            this.Usuario = string.Empty;
            this.Clave = string.Empty;
            this.FechaIngreso = DateTime.Now;
        }
    }
}
