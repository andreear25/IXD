using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x; 
            bool isNumber = int.TryParse(textBox1.Text, out x); // isnumber poate contine doar True sau false

            if (isNumber)
            {
                //Algoritmul de numar prim
                int nr_div = 0;
                for(int i = 1; i<=x; i++)
                {
                    if (x % i == 0)
                        nr_div++;
                }
                if (nr_div == 2)
                {
                    BackColor = Color.Green;
                }
                else
                {
                    BackColor = Color.Red;
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Buna, nu ai introdus un numar , vrei sa mai incerci odata ?", "Eroare", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    textBox1.Text = "";
                    BackColor = Color.Purple;
                }
                else if (dialogResult == DialogResult.No)
                {
                    BackColor = Color.Yellow;
                }
            }
        }
    }
}
