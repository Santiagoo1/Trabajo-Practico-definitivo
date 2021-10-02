using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_definitivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        
        
        {
            Form menu1 = new Menu();
            if (Tbcontraseña.Text == "2209") 


            {

                this.Hide(); menu1.Show();



            }


            else
                label5.Text = "contraseña incorrecta";
            
            label5.Show();












        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario2 = new Form1();
            Form formulario = new Dudas();    
           formulario.Show();
            this.Hide();
            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
