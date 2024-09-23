using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            dgvDatos.Rows.Add(NFilas);
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDatos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {



        }

        private void dgvDatos_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void dgvDatos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double SumaX = 0;
            double SumaY = 0;
            double SumaXCuadrado = 0;
            double SumaYCuadrado = 0;
            double SumaXY = 0;
           Calculos calculos = new Calculos();
            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {

                    if (double.TryParse(dgvDatos.Rows[i].Cells[0].Value?.ToString(), out double valorX))
                    {
                        SumaX = valorX + SumaX;
                        double resultadoX = Math.Pow(valorX, 2);
                        dgvDatos.Rows[i].Cells[2].Value = resultadoX;
                        SumaXCuadrado = SumaXCuadrado + resultadoX;
                    }


                    if (double.TryParse(dgvDatos.Rows[i].Cells[1].Value?.ToString(), out double valorY))
                    {
                        SumaY = valorY + SumaY;
                        double resultadoY = Math.Pow(valorY, 2);
                        dgvDatos.Rows[i].Cells[3].Value = resultadoY;
                        SumaYCuadrado = SumaYCuadrado + resultadoY;
                    }

                if (double.TryParse(dgvDatos.Rows[i].Cells[0].Value?.ToString(), out double valorX2) && double.TryParse(dgvDatos.Rows[i].Cells[1].Value?.ToString(), out double valorY2)) {
                    double ResultadoXY = valorX2 * valorY2;
                    SumaXY = SumaXY + ResultadoXY;
                    dgvDatos.Rows[i].Cells[4].Value = ResultadoXY;
                }

            }
            txtPrueba.Text = Convert.ToString(SumaXY);
            b1txt.Text = Convert.ToString((Math.Truncate( calculos.b1(SumaXY,SumaX,SumaY,SumaXCuadrado,NFilas)*10000))/10000);

            b0txt.Text = Convert.ToString((Math.Truncate(calculos.b0()*10000))/10000);
            RVtxt.Text = Convert.ToString((Math.Truncate(calculos.RV1(SumaYCuadrado) * 10000))/10000); 
            Rcuadradotxt.Text = Convert.ToString((Math.Truncate(calculos.R2() * 10000))/10000);
            Rtxt.Text = Convert.ToString((Math.Truncate(calculos.R() * 10000))/10000);
            Ttxt.Text = Convert.ToString((Math.Truncate(calculos.t_student() * 10000)) / 10000);
        }
    }
}
