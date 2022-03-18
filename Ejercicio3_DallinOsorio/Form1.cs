using DatosEjer3.Accesos;
using DatosEjer3.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_DallinOsorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ingresarbutton_Click(object sender, EventArgs e)
        {
            UsuarioAcces usuarioDA = new UsuarioAcces();
            Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(UsuariotextBox.Text, ContraseñatextBox.Text);

            if (usuario == null)
            {
                MessageBox.Show("Datos erroneos");
                return;
            }

            MessageBox.Show("Se ha conectado Correctamente");

            DatosIngresados datosIngresados = new DatosIngresados();
            datosIngresados.Show();
        }
    }
}
