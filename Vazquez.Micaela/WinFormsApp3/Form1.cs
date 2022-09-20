using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_2_I05;

namespace WinFormsApp3
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Tabla";
            label1.Text = "Ingrese un numero: ";
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                string numeroIngresado = txtNumero.Text;
                int num;
                int multiplicacion;

                //muestra solo una vez
                //if (numeroIngresado.All(char.IsDigit))
                //{
                    num = int.Parse(numeroIngresado);

                    for(int i = 1; i<= 10;i++)
                    {
                        multiplicacion = num * i;
                        this.IstTabla.Items.Add(num + " X " + i + " = " + multiplicacion);
                    }
                //}
                //else
                //{
                //    MessageBox.Show("No es valido...","Error!",MessageBoxButtons.OK);

                //}


            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.IstTabla.Items.Clear();
            this.txtNumero.Text = " ";
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de salir de la aplicacion?", "Atencion!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
