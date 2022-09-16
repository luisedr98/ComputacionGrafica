using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppImplementacion
{
    internal class Segmento3D : Vector3D
    {
        double t, dt;
        double xo, xf, yo, yf, zo, zf;
        Color apagado;

        public Segmento3D(double Xo, double xf, double Yo, double yf, double zo, double zf, PictureBox pb) : base(pb)
        {
            this.xo = Xo;
            this.yo = Yo;
            this.zo = zo;
            this.zf = zf;
            this.xf = xf;
            this.yf = yf;
            this.zf = zf;
            apagado = pb.BackColor;
        }

        
        public Bitmap Encender(Color c)
        {
            t = 0; dt = 0.0005;
            do
            {
                double Xo = xo * (1 - t) + xf * (t);
                double Yo = yo * (1 - t) + yf * (t);
                double Zo = zo * (1 - t) + zf * (t);
                base.Encender(Xo, Yo, Zo, c);
                t = dt + t;
            }while (t<=1);
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
