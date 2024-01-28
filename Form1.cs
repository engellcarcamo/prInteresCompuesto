using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prInteresCompuesto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("¡Bienvenido al formulario!");
        }


        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {   
            //Declaración de variables
            double capital, razon, tiempo;
            double interes, monto;

            //Capturando la entrada de los datos
            capital = double.Parse(txtcapital.Text);
            razon = double.Parse(txtrazon.Text);
            tiempo = double.Parse(txttiempo.Text);

            //Proceso de datos
            monto = Math.Pow((1+razon), tiempo) * capital;
            interes = monto - capital;

            //Salida de Información
            txtmontofinal.Text= $"$ {Convert.ToString(monto)}";
            txttotalinteres.Text = $"$ {Convert.ToString(interes)}";
             
        }

        private void btnnuevo_Click_1(object sender, EventArgs e)
        {
            LimpiarControles(this.Controls);
        }
  

        private void LimpiarControles(Control.ControlCollection controles)
        {
            foreach (Control control in controles)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                
                if (control.HasChildren)
                {
                    LimpiarControles(control.Controls);
                }
            }
        }
    }
}
