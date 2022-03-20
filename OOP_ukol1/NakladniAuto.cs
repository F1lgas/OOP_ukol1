using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ukol1
{
    class NakladniAuto
    {
        private string spz;
        private int nosnost;
        private int naklad;
        private int zbytek = 0;

        public NakladniAuto(string spz, int nosnost)
        {
            this.spz = spz;
            this.nosnost = nosnost;
        }

        public void NalozNaklad(int naklad)
        {
            if (naklad > nosnost)
            {
                zbytek = naklad - nosnost;
                this.naklad = naklad - zbytek;
                MessageBox.Show("Bylo naloženo pouze " + naklad + " tun , nelze naložit zbývajících "+ zbytek + "!", "Problém");
            }
            else
            {
                this.naklad += naklad;
                MessageBox.Show("Náklad byl úspěšně naložen!");
            }
        }

        public void VylozNaklad(int naklad)
        {
            if (zbytek > 0)
            {
                MessageBox.Show("Náklad byl úspěšně vyložen, ale chybí " + Convert.ToString(zbytek) + " tun!", "Problém");
                naklad = 0;
                this.naklad = 0;
            }
            else
            {
                MessageBox.Show("Náklad byl úspěšně vyložen!");
                naklad = 0;
                this.naklad = 0;
            }
        }

        public override string ToString()
        {
            return String.Format("Nákladní auto {0} má nosnost {1} tun a má naloženo {2} tun.", this.spz, this.nosnost, this.naklad);
        }
    }
}