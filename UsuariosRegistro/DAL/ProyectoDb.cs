using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosRegistro.Entidades;

namespace UsuariosRegistro.DAL
{
    class ProyectoDb :DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public ProyectoDb() : base("ConStr")
        {

        }
    }
}
