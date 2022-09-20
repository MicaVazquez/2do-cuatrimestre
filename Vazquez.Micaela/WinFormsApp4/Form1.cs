using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int importe;
            float descuento = 0;
            float total;

            importe = int.Parse(this.textBox1.Text);
            
            if(importe > 5000)
            {
                descuento = importe * 20/100;
            }
            else if(importe > 3000)
            {
                descuento = importe *  10/100;
            }

            total = importe - descuento;

            this.textBox2.Text = descuento.ToString();
            this.textBox3.Text = total.ToString();


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
             
            foreach(Control c in this.groupBox1.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = " ";
                    this.textBox1.Focus();
                    //((TextBox)c).Clear();
                }
            }

        }
    }
}
