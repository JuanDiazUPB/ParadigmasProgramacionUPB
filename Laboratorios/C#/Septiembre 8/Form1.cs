using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbDocumento.Items.Add("CC"); cmbDocumento.Items.Add("CE"); cmbDocumento.Items.Add("TI"); cmbDocumento.Items.Add("PA"); cmbDocumento.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Por favor solo digite números en la casilla Documentos.");
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (!Char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("Por favor solo teclee letras en la casilla Nombre.");
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (!Char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("Por favor solo digite números en la casilla Edad.");
                e.Handled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string tipoDocumento = cmbDocumento.SelectedItem.ToString(),
                   documento = txtDocumento.Text,
                   nombre = txtNombre.Text,
                   genero = "",
                   edad = txtEdad.Text;


            if (rbtnMasculino.Checked == true)
            {
                genero = "Masculino";
            }
            else
            if (rbtnFemenino.Checked == true)
            {
                genero = "Femenino";
            }

            MessageBox.Show(String.Format("Registro completado, los datos ingresados fueron: \n" +
                "Tipo de Documento: {0} \n" +
                "Documento: {1} \n" +
                "Nombre: {2} \n" +
                "Genero: {3} \n" +
                "Edad: {4}"
                 , tipoDocumento, documento, nombre, genero, edad));
        }
    }
}
