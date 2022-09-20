using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//botonAgregar
        {
            listBox1.Items.Add(textBox1.Text);
            this.textBox1.Text = ""; 
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            ordenamientoBurbuja();
            
        }

        private void ordenamientoBurbuja()
        {
            int contadorNum = this.listBox1.Items.Count;


            for (int i = 0; i < contadorNum; i++)
            {
                for (int j = i + 1; j < contadorNum; j++)
                {
                    if (this.radioButtonAsc.Checked == true)
                    {
                        if (int.Parse(this.listBox1.Items[i].ToString()) > int.Parse(this.listBox1.Items[j].ToString()))
                        {
                            int aux = int.Parse(this.listBox1.Items[i].ToString());
                            this.listBox1.Items[i] = this.listBox1.Items[j];
                            this.listBox1.Items[j] = aux;

                        }

                    }
                    else
                    {
                        if (int.Parse(this.listBox1.Items[i].ToString()) < int.Parse(this.listBox1.Items[j].ToString()))
                        {
                            int aux = int.Parse(this.listBox1.Items[i].ToString());
                            this.listBox1.Items[i] = this.listBox1.Items[j];
                            this.listBox1.Items[j] = aux;
                        }
                    }
                }
            }

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control groupBox in this.groupBox1.Controls)
            {
                if (groupBox is TextBox)
                { 
                    foreach(Control item in groupBox.Controls)
                    {
                        if(item is ListBox lista)
                        {
                            lista.Items.Clear();
                        }

                        if (item is TextBox txtBox)
                        {
                            txtBox.Clear();
                        }

                        if (item is RadioButton radioButton)
                        {
                            radioButton.Enabled = false;
                        }
                    }
                }
            }
        }
    }
}
