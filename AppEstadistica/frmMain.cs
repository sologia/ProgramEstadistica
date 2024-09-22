using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEstadistica
{
    public partial class frmMain : Form
    {
        public int Cantidad;
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //agregar excepcion aca pls
            try
            {
                Cantidad = int.Parse(txtCantidad.Text);
                frmDatos frmDatos = new frmDatos(Cantidad);
                frmDatos.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        private void txtCantidad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
    }
}
