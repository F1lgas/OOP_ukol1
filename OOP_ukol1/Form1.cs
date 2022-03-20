using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ukol1
{
    public partial class Form1 : Form
    {
        NakladniAuto nakladniauto;

        public Form1()
        {
            InitializeComponent();
        }

        private void vytvorit_Click(object sender, EventArgs e)
        {
            if (vytvorit.Text == "")
            {
                MessageBox.Show("Prvně musíš zadat hodnoty!");
            }
            else
            {
                nakladniauto = new NakladniAuto(textBox_SPZ.Text, Convert.ToInt32(textBox_nosnost.Text));
                MessageBox.Show("Auto bylo úspěšně vytvořeno!");
            }
        }

        private void nalozit_Click(object sender, EventArgs e)
        {
            if (nalozit.Text == "")
            {
                MessageBox.Show("Prvně musíš zadat hodnoty!");
            }
            else
            {
                nakladniauto.NalozNaklad(Convert.ToInt32(textBox_naklad.Text));
            }
        }

        private void vylozit_Click(object sender, EventArgs e)
        {
            if (nalozit.Text == "")
            {
                MessageBox.Show("Prvně musíš zadat hodnoty!");
            }
            else
            {
                nakladniauto.VylozNaklad(Convert.ToInt32(textBox_naklad.Text));
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nakladniauto.ToString());
        }
    }
}