using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuariosRegistro.UI.Registros;

namespace UsuariosRegistro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new rUsuarios().ShowDialog();
        }

        private void FibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new rFibonacci().ShowDialog();
        }
    }
}
