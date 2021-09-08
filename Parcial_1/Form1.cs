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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCerrar.Visible = false;
        }

        public void iniciarSesion(string usuario)
        {
            Form nuevoForm;
            if (usuario == "Administrador")
            {
                nuevoForm = new Form2();
                nuevoForm.Show();
            }
            if (usuario == "Empleado")
            {
                nuevoForm = new Form3();
                nuevoForm.Show();
            }
        }
        
        private void btnIngreso_Click(object sender, EventArgs e)
        {
            string usuario;
            if (txtUsuario.Text == "Claudia" && txtContraseña.Text == "Pastelitos")
            {
                usuario = "Administrador";
                MessageBox.Show("Iniciando como Administrador... \n\nBienvenida, Claudia");
                iniciarSesion(usuario);
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                txtUsuario.Visible = false;
                txtContraseña.Visible = false;
                btnIngreso.Visible = false;
                btnCerrar.Visible = true;
            }
            else
            if (txtUsuario.Text == "Anita" && txtContraseña.Text == "Croissant")
            {
                usuario = "Empleado";
                MessageBox.Show("Iniciando como Empleada... \n\nBienvenida, Anita");
                iniciarSesion(usuario);
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                txtUsuario.Visible = false;
                txtContraseña.Visible = false;
                btnIngreso.Visible = false;
                btnCerrar.Visible = true;
            }
            else
            {
                MessageBox.Show("Inicio de sesión incorrecto...");
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            txtUsuario.Visible = true;
            txtContraseña.Visible = true;
            btnIngreso.Visible = true;
            btnCerrar.Visible = false;
        }
    }
}
