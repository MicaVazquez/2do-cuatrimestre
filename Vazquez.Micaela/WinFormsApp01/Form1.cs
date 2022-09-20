using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp01
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Cambiando en el Load";
            this.BackColor = Color.SteelBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dicen que el tiempo todo lo arregla por donde pasa...", "Hola", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.button1.BackColor =  Color.Aquamarine;
            string texto = this.textBox1.Text;
            this.Text += texto;
            this.listBox1.Items.Add(this.textBox1.Text);
            this.MiMetodo(texto);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.ForeColor = Color.BlueViolet;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.DarkBlue;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Back)
            {
                this.Close();
            }
            MessageBox.Show(e.KeyChar.ToString());
        }

        public void MiMetodo(string a)
        {
            this.Opacity = 0.3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmFormularioX frm = new FrmFormularioX();
            frm.MdiParent = this;

                frm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Continua con la app?","Ojo",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                e.Cancel = true;
            }
           
        }
    }
}
