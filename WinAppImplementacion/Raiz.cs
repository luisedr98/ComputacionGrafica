using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppImplementacion
{
    internal class Raiz : Circunferencia
    {
        Color apagado;
        int Xo, Yo;
        double r;
        double t = 0;
        double dt = 0.001;

        public Raiz(double Xo, double Yo, double r, PictureBox pb) : base(Xo, Yo, r, pb)
        {
            this.apagado = pb.BackColor;
            this.r = Sr(r);
            this.Yo = PantallaSy(Yo);
            this.Xo = PantallaSx(Xo);
        }

        public Bitmap Encender(Color c)
        {

            t = 0;
            dt = 0.001;
            do
            {
                int y = (int)(Yo + r * Math.Cos((double)(3*t)));
                int x = (int)(Xo + r * Math.Sin((double)(2*t)));
                base.Encender(x, y, c);
                t = t + dt;
            } while (t <= (2 * Math.PI));

            return bmp;
        }

        public Bitmap Apagar(PictureBox pantalla)
        {
            if(pantalla.Image == null)
            {
                bmp = new Bitmap(700, 420);
            }
            else bmp = new Bitmap(pantalla.Image);
            return bmp =Encender(apagado);
        }
    }

}
