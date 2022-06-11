using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_CARINOR_2._0
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "USUARIO")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "carinor")
            {
                if (textBox2.Text == "12345")
                {
                    MessageBox.Show("Bienvenido Jorge");
                    //FLogin f new = FPrincipal ();
                    //F.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("LA CONTRASEÑA ES INCORRECTA");
                    textBox1.Clear();
                    textBox2.Clear();
                }

            }
            else
            {
                MessageBox.Show("EL USUARIO ES INCORRECTO");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "USUARIO";
                textBox1.ForeColor = Color.Black;

            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "CONTRASEÑA");
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.UseSystemPasswordChar = true;

            }            

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "CONTRASEÑA";
                textBox2.ForeColor = Color.Black;
                textBox2.UseSystemPasswordChar = false;
            }
        }
    }
}
