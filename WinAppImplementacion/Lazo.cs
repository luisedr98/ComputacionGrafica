using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppImplementacion
{
    internal class Lazo: Circunferencia
    {
        int Xo;
        int Yo;
        double Radio;
        Color apagado;

        public Lazo(double Xo, double Yo, double Radio, PictureBox pb): base(Xo, Yo, Radio, pb)
        {
            this.apagado = pb.BackColor;
            this.Yo = PantallaSy(Yo);
            this.Radio = Sr(Radio);
            this.Xo = PantallaSx(Xo);
        }

        public Bitmap Encender(Color c)
        {
            double t = 0;
            double dt = 0.001;
            do
            {
                int x = (int)(Xo + (Radio * Math.Cos(2 * t)));
                int y = (int)(Yo + (Radio * Math.Sin(3 * t)));
                base.Encender(x, y, c);
                t = t + dt;
            } while (t <= (3*Math.PI));

            return bmp;
        }

        public Bitmap Apagar(PictureBox pantalla)
        {
            if (pantalla.Image == null)
            {
                bmp = new Bitmap(700, 420);
            }
            else bmp = new Bitmap(pantalla.Image);
            return bmp = Encender(apagado);
        }
    }
}
