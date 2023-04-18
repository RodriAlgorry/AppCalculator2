using AppCalculator2.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadora2
{
    public partial class frmCalculadora : Form
    {
        public Calculadora oCalculadora = new Calculadora();
        public frmCalculadora()
        {
            InitializeComponent();
            oCalculadora.Resultado = 0;
        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            string Respuesta = oCalculadora.Operacion("+",txtOperador1.Text);
            if ( Respuesta == "")
            {
                lblResultado.Text = oCalculadora.Resultado.ToString();
            }
            else
            {
                lblResultado.Text = Respuesta;
            }
            txtOperador1.Text = "";
            txtOperador1.Focus();
        }

        private void btResta_Click(object sender, EventArgs e)
        {
            string Respuesta = oCalculadora.Operacion("-", txtOperador1.Text);
            if (Respuesta == "")
            {
                lblResultado.Text = oCalculadora.Resultado.ToString();
            }
            else
            {
                lblResultado.Text = Respuesta;
            }
            txtOperador1.Text = "";
            txtOperador1.Focus();
        }

        private void btMultiplicacion_Click(object sender, EventArgs e)
        {
            
            string Respuesta = oCalculadora.Operacion("*", txtOperador1.Text);
            if (Respuesta == "")
            {
                lblResultado.Text = oCalculadora.Resultado.ToString();
            }
            else
            {
                lblResultado.Text = Respuesta;
            }
            txtOperador1.Text = "";
            txtOperador1.Focus();
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            string Respuesta = oCalculadora.Operacion("/", txtOperador1.Text);
            if (Respuesta == "")
            {
                lblResultado.Text = oCalculadora.Resultado.ToString();
            }
            else
            {
                lblResultado.Text = Respuesta;
            }
            txtOperador1.Text = "";
            txtOperador1.Focus();
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            string Respuesta = oCalculadora.Operacion("=", txtOperador1.Text);
            if (Respuesta == "")
            {
                lblResultado.Text = oCalculadora.Resultado.ToString();
            }
            else
            {
                lblResultado.Text = Respuesta;
            }
            txtOperador1.Text = "";
            txtOperador1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oCalculadora = null;
            oCalculadora = new Calculadora();
            txtOperador1.Text = "0";
            lblResultado.Text = "";
            txtOperador1.Focus();
            txtOperador1.SelectAll();
        }
    }
}
