using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageListKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPromjeni_Click(object sender, EventArgs e)
        {
            int brojac = 0;
                if(brojac == 0)
            {

                pictureBox1.Image = imageList1.Images[0];
                brojac++;

            }
            if (brojac == 1)
            {

                pictureBox1.Image = imageList1.Images[1];
                brojac++;

            }
            if (brojac == 2)
            {

                pictureBox1.Image = imageList1.Images[2];
                brojac++;

            }
            if (brojac == 3)
            {

                pictureBox1.Image = imageList1.Images[3];
                brojac = 0;

            }

        }
    }
}
