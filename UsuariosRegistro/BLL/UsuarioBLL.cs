using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosRegistro.DAL;
using UsuariosRegistro.Entidades;

namespace UsuariosRegistro.BLL
{
    class UsuarioBLL
    {
        public static bool Guardar(Usuarios usuarios)
        {
            bool estado = false;
            try
            {
                ProyectoDb context = new ProyectoDb();
                context.Usuarios.Add(usuarios);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;
        }

        public static bool Editar(Usuarios usuarios)
        {
            bool paso = false;

            ProyectoDb contexto = new ProyectoDb();
            try
            {
                contexto.Entry(usuarios).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;

            ProyectoDb contexto = new ProyectoDb();
            try
            {
                Usuarios usuarios = contexto.Usuarios.Find(id);

                contexto.Usuarios.Remove(usuarios);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
        public static Usuarios Buscar(int id)
        {
            ProyectoDb contexto = new ProyectoDb();
            Usuarios usuarios = new Usuarios();
            try
            {
                usuarios = contexto.Usuarios.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return usuarios;
        }
    }
}
