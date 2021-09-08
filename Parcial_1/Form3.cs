using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_JuanDiaz
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }



        private void btnVenta_Click(object sender, EventArgs e)
        {
            int cntdAlinado = int.Parse(nmudAlinado.Value.ToString()),
                cntdNoAlinado = int.Parse(nmudNoAlinado.Value.ToString()),
                cntdEspecial = int.Parse(nmudEspecial.Value.ToString()),
                totalVenta = (cntdAlinado * 1000 + cntdNoAlinado * 500 + cntdEspecial * 2000);

            DateTime horaVenta = DateTime.Now;

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Aun faltan valores por llenar...");
            }
            if (txtID.Text == "")
            {
                MessageBox.Show("Aun faltan valores por llenar...");
            }
            else
            {
                MessageBox.Show(String.Format("OnlyPans\nRegistro de venta\n\n" +
                    "Hora de la venta: {0}\n\n" +
                    "Cliente: {1}\n" +
                    "ID: {2}\n" +
                    "Pan Aliñado: {3}\n" +
                    "Pan No Aliñado: {4}\n" +
                    "Pan Especial: {5}\n" +
                    "Total de la venta: $ {6}"
                    , horaVenta, txtNombre.Text, txtID.Text, cntdAlinado, cntdNoAlinado, cntdEspecial, totalVenta));
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (!Char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("Ingrese un valor válido.");
                e.Handled = true;
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (!Char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("Ingrese un valor válido.");
                e.Handled = true;
            }
        }
    }
}
