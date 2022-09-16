using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppImplementacion
{
    internal class Onda3D: Vector3D
    {
        double m, t, v, w;
        public Onda3D(PictureBox pb, double w, double t,double v, double m) : base(pb)
        {
            this.m = m;
            this.t = t;
            this.v = v;
            this.w = w;
        }

        public void graf3D(Color c)
        {
            double dt, y, h, dh;
            dt = 0.1;
            y = -8;
            do
            {
                h = -5;
                dh = 0.1;
                do
                {
                    double x = y;
                    double y1 = h;
                    double z = w * Math.Sqrt(Math.Pow((x - 5), 2) + Math.Pow((y1 - 0), 2)) - v * t;
                    z = m * Math.Sin(z);
                    double z2 = w * Math.Sqrt(Math.Pow((x + 5), 2) + Math.Pow((y1 - 0), 2)) - v * t;
                    z2 = m * Math.Sin(z2);
                    double zf = z+z2;
                    Encender(x, y1, zf,c);
                    h = h + dh;
                } while (h < 5);
                y = y + dt;
            } while (y < 8);
        }

        public void fuente3D(Color c)
        {
            double dt, y, h, dh;
            dt = 0.1;
            y = -8;
            do
            {
                h = -5;
                dh = 0.1;
                do
                {
                    double x = y;
                    double y1 = h;
                    double z = w * Math.Sqrt(Math.Pow((x - 5), 2) + Math.Pow((y1 - 0), 2)) - v * t;
                    z = m * Math.Sin(z);
                    double zf = z;
                    Encender(x, y1, zf, c);
                    h = h + dh;
                } while (h < 5);
                y = y + dt;
            } while (y < 8);
        }
    }
}
