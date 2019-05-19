using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsuariosRegistro.UI.Registros
{
    public partial class rFibonacci : Form
    {
        public rFibonacci()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            int numero, resultado = 1;
            numero= Convert.ToInt32(NumeroTextBox1.Text);

           // numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
                resultado = resultado * i;
            ResultadotextBox.Text = resultado.ToString();

        }
    }
}
