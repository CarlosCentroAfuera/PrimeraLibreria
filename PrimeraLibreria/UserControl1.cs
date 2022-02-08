using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraLibreria
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void textChange1(object sender, EventArgs e)
        {
            numVeces++;
            if (text1.Text.Length < 8)
            {
                textBox2.BackColor = Color.Red;
                textBox2.ForeColor = Color.Yellow;
                textBox2.Text = "Contraseña muy corta";

            }
            else
            {
                textBox2.BackColor = Color.Green;
                textBox2.ForeColor = Color.White;

                textBox2.Text = "Contraseña válida. Has tecleado " + numVeces + " veces para conseguirlo.";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
