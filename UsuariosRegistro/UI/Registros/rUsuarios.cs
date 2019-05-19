using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuariosRegistro.BLL;
using UsuariosRegistro.Entidades;

namespace UsuariosRegistro.UI.Registros
{
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }
        void limpiar()
        {

            NombrestextBox.Text = " ";
            UsuariotextBox.Text = " ";
            EmailtextBox.Text = " ";
            ClavetextBox.Text = " ";
            NivelUsuariotextBox.Text = " ";
        }

        public Usuarios LlenaClase()
        {
            Usuarios usuarios = new Usuarios();

            usuarios.Nombres = NombrestextBox.Text;
            usuarios.Email = EmailtextBox.Text;
            usuarios.NivelUsuario = int.Parse(NivelUsuariotextBox.Text);
            usuarios.Usuario = UsuariotextBox.Text;
            usuarios.Clave = ClavetextBox.Text;
            usuarios.FechaIngreso = FechaIngresoDateTimePicker.Value;


            return usuarios;

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
          

            Usuarios usuarios = UsuarioBLL.Buscar((int)IdnumericUpDown.Value);

           if (Validar(2))
            {
            if (usuarios == null)
            {
                if (UsuarioBLL.Guardar(LlenaClase()))
                    MessageBox.Show("Guardado Con Exito");
                else
                    MessageBox.Show("El Cliente No Se Guardo");
            }
            else
            {
                if (UsuarioBLL.Editar(LlenaClase()))
                    MessageBox.Show("Modificado Con Exito");
                else
                    MessageBox.Show("El Cliente No Se Modifico");
            }
        }
            else
              
            LimpiarProvider();
        

    }
        private void LimpiarProvider()
        {
            IdErrorProvider.Clear();
            OtroErrorProvider.Clear();
        }
        public bool Validar(int error)
        {
            bool paso = false;

            if (error == 1 && IdnumericUpDown.Value == 0)
            {
                IdErrorProvider.SetError(IdnumericUpDown, "Debe Ingresar Un Id");
                paso = true;
            }
            if (error == 2 && NombrestextBox.Text == string.Empty)
            {
                OtroErrorProvider.SetError(NombrestextBox, "Debe Ingresar Un Nombre");
                paso = true;
            }
            if (error == 2 && EmailtextBox.Text == string.Empty)
            {
                OtroErrorProvider.SetError(EmailtextBox, "Debe Ingresar Una Email");
                paso = true;
            }
            if (String.IsNullOrEmpty(NivelUsuariotextBox.Text))
            {
                OtroErrorProvider.SetError(NivelUsuariotextBox,
                    "Debe digitar un Cantidad de Entrada para el Producto");
                paso = true;
            }
            //if (error == 2 && NivelUsuariotextBox.Text == string.Empty)
            //{

            //    OtroErrorProvider.SetError(NivelUsuariotextBox, "Debe Ingresar Una Cedula");
            //    paso = true;
            //}
            if (error == 2 && UsuariotextBox.Text == string.Empty)
            {
                OtroErrorProvider.SetError(UsuariotextBox, "Debe Ingresar Una Usuario");
                paso = true;
            }
            if (error == 2 && ClavetextBox.Text == string.Empty)
            {

                OtroErrorProvider.SetError(ClavetextBox, "Debe Ingresar Un Telefono");
                paso = true;
            }

            return paso;

        }
        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);
            Usuarios usuarios = BLL.UsuarioBLL.Buscar(id);

            if (usuarios != null)
            {
           
                FechaIngresoDateTimePicker.Value = usuarios.FechaIngreso;
                NombrestextBox.Text = usuarios.Nombres;
                UsuariotextBox.Text = usuarios.Usuario;
                EmailtextBox.Text = usuarios.Email;
                ClavetextBox.Text = usuarios.Clave;
                NivelUsuariotextBox.Text = usuarios.NivelUsuario.ToString();
            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(IdnumericUpDown.Value);

            if (BLL.UsuarioBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
 
}
