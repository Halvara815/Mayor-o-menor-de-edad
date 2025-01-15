using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayor_o_menor_de_edad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            // Obtener el texto del TextBox
            string entrada = txtEdad.Text;
            int edad;

            // Validar que sea un número entero
            if (int.TryParse(entrada, out edad) && edad >= 0)
            {
                if (edad >= 18)
                {
                    lblResultado.Text = "Eres mayor de edad.";
                    lblResultado.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblResultado.Text = "Eres menor de edad.";
                    lblResultado.ForeColor = System.Drawing.Color.Blue;
                }
            }
            else
            {
                lblResultado.Text = "Por favor, ingrese un número entero válido.";
                lblResultado.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            string entrada = txtEdad.Text;

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Eres mayor de edad."; // Si es mayor de edad
            lblResultado.ForeColor = System.Drawing.Color.Green;

            lblResultado.Text = "Eres menor de edad."; // Si es menor de edad
            lblResultado.ForeColor = System.Drawing.Color.Blue;

            lblResultado.Text = "Por favor, ingrese un número entero válido."; // Si no es válido
            lblResultado.ForeColor = System.Drawing.Color.Red;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
        
    

