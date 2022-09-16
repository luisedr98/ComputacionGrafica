using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppImplementacion
{
    internal class Paleta
    {
        public Color[] paleta;
        public Color[] paleta2;
        public Color[] paleta3;
        public Color[] paleta4;

        public Paleta()
        {
            this.llenarpaletadef();
            this.llenarpersonal();
            this.llenarp3();
            this.llenarp4();

        }

        public void llenarpaletadef()
        {
            paleta = new Color[16];
            paleta[0] = Color.Black;
            paleta[1] = Color.Navy;
            paleta[2] = Color.Green;
            paleta[3] = Color.Aqua;
            paleta[4] = Color.Red;
            paleta[5] = Color.Purple;
            paleta[6] = Color.Maroon;
            paleta[7] = Color.LightGray;
            paleta[8] = Color.DarkGray;
            paleta[9] = Color.Blue;
            paleta[10] = Color.Lime;
            paleta[11] = Color.Silver;
            paleta[12] = Color.Teal;
            paleta[13] = Color.Fuchsia;
            paleta[14] = Color.Yellow;
            paleta[15] = Color.White;
        }

        public void llenarpersonal()
        {
            paleta2 = new Color[16];
            paleta2[0] = Color.Teal;
            paleta2[1] = Color.Violet;
            paleta2[2] = Color.Green;
            paleta2[3] = Color.Aqua;
            paleta2[4] = Color.Cyan;
            paleta2[5] = Color.Purple;
            paleta2[6] = Color.Lavender;
            paleta2[7] = Color.LightGray;
            paleta2[8] = Color.DarkGray;
            paleta2[9] = Color.Blue;
            paleta2[10] = Color.Gold;
            paleta2[11] = Color.Silver;
            paleta2[12] = Color.Beige;
            paleta2[13] = Color.Fuchsia;
            paleta2[14] = Color.OrangeRed;
            paleta2[15] = Color.White;
        }

        public void llenarp3()
        {
            paleta3 = new Color[16];
            for (int i =0; i<16; i++)
            {
                int g = (int)-1.33 * (i - 15) + (17 * i);
                int b = (int)-2 * (i - 15) + (17 * i);
                paleta3[i] = Color.FromArgb(0, g, b);
            }
        }

        public void llenarp4()
        {
            paleta4 = new Color[16];
            for (int i = 0; i < 16; i++)
            {
                int g = (int)((128 * i )/ 15);
                int b = (int)(-255 * (i - 15)) / 15;
                paleta4[i] = Color.FromArgb(0, g, b);
            }
        }




    }
}
