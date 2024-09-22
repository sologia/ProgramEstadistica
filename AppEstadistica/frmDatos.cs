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
    public partial class frmDatos : Form
    {
        private int NFilas;
        public frmDatos(int Cantidad)
        {
            InitializeComponent();
            NFilas = Cantidad;
            NFilas = NFilas + 1;
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDatos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {


            try
            {
                if (dgvDatos.Rows.Count > NFilas)
                {
                    dgvDatos.AllowUserToAddRows = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Solo se permiten {NFilas} filas.");
            }
        }

        private void dgvDatos_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void dgvDatos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {

                    if (double.TryParse(dgvDatos.Rows[i].Cells[0].Value?.ToString(), out double valorX))
                    {
                        double resultadoX = Math.Pow(valorX, 2);
                        dgvDatos.Rows[i].Cells[2].Value = resultadoX;
                    }


                    if (double.TryParse(dgvDatos.Rows[i].Cells[1].Value?.ToString(), out double valorY))
                    {
                        double resultadoY = Math.Pow(valorY, 2);
                        dgvDatos.Rows[i].Cells[3].Value = resultadoY;
                    }

                if (double.TryParse(dgvDatos.Rows[i].Cells[0].Value?.ToString(), out double valorX2) && double.TryParse(dgvDatos.Rows[i].Cells[1].Value?.ToString(), out double valorY2)) {
                    double ResultadoXY = valorX2 * valorY2;
                    dgvDatos.Rows[i].Cells[4].Value = ResultadoXY;
                }

            }
        }
    }
}
