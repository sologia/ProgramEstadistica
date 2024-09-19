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
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    if (double.TryParse(dgvDatos.Rows[e.RowIndex].Cells[0].Value?.ToString(), out double valorX))
                    {
                        double ResultadoX = Math.Pow(valorX, 2);
                        dgvDatos.Rows[e.RowIndex].Cells[2].Value = ResultadoX;
                    }
                    else
                    {
                        //comprobar que sea un numero, sino lo elimina
                        dgvDatos.Rows[e.RowIndex].Cells[2].Value = null;
                    }
                }

                else if (e.ColumnIndex == 1)
                {
                    if (double.TryParse(dgvDatos.Rows[e.RowIndex].Cells[1].Value?.ToString(), out double valorY))
                    {
                        double ResultadoY = Math.Pow(valorY, 2);

                        dgvDatos.Rows[e.RowIndex].Cells[3].Value = ResultadoY;
                    }
                    else
                    {
                        //comprobar que sea un numero, sino lo elimina
                        dgvDatos.Rows[e.RowIndex].Cells[3].Value = null;
                    }
                }
            }
        }
    }
}
