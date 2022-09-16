using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppImplementacion
{
    internal class Segmento: Vector
    {
        double Xf, Yy; 
        double Xo, Yo;
        double dt, t;
        Color apagado;



        public Segmento(double Xo, double Xf, double Yo, double Yy, PictureBox pb): base(pb)
        {
            this.Xo = PantallaSx(Xo);
            this.Yo = PantallaSy(Yo);
            this.Xf = PantallaSx(Xf);
            this.Yy = PantallaSy(Yy);
            apagado = pb.BackColor;
        }
  

        public Bitmap Encender(Color c)
        {
            t = 0;
            dt = 0.001;
            do
            {
                int x = (int)(((Xo) * (1 - t)) + (Xf * t));
                int y = (int)(((Yo) * (1 - t)) + (Yy * t));
                base.Encender(x, y, c);
                t = t + dt;
            } while (t <= 1);

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
