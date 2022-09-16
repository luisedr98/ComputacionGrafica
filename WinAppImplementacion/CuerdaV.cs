using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppImplementacion
{
    internal class CuerdaV:Vector
    {
        double t;
        double l;
        double c;
       
        public CuerdaV(PictureBox pb, double t, double l, double c) : base(pb)
        {
            this.t = t;
            this.l = l;
            this.c = c;
          
        }

        public void Grafico(Color c)
        {
            double x=0;
            do
            {
                int xo = PantallaSx(x);
                this.Fuorier(x, out double sol);
                int yo = PantallaSy(sol);
                Encender(xo, yo, c);
                x = x + 0.005;
            } while (x <= l);
        }

        public void Fuorier(double x, out double sol)
        {
            double ak, bk, sum=0;
            int k= 1;
            do
            {
                //bk = ((2.0 / (k * Math.PI * c)) * (l / 6.0) * ((this.g(0) * Math.Sin(k * Math.PI * 0 / l)) + ((4.0 * this.g(l / 2.0)) * Math.Sin(((k * Math.PI) / 2.0)) + this.g(l) * Math.Sin(k * Math.PI))));
                //ak = ((2.0 / l) * (l / 6.0) * ((this.f(0) * Math.Sin(k * Math.PI * 0 / l)) + ((4.0 * this.f(l / 2.0)) * Math.Sin(((k * Math.PI) / 2.0)) + this.f(l) * Math.Sin(k * Math.PI))));
                //sum = sum + ((ak * Math.Cos((k * Math.PI * c * t) / 2)) + (bk * Math.Sin((k * Math.PI * c * t) / 2))) * Math.Sin((k * Math.PI * x) / l);


                ak = (2.0 / l) * (l / 6.0);
                ak = ak * (0 + 4 * this.f(l / 2.0) * Math.Sin(k * Math.PI / 2.0) + 0);
                bk = (2.0 / (k * Math.PI * c)) * (l / 6.0);
                bk = bk * (0 + 4 * this.g(l / 2.0) * Math.Sin((k * Math.PI) / 2.0) + 0);
                sum = sum + (ak * Math.Cos((k * Math.PI * c * t) / l) + bk * Math.Sin((k * Math.PI * c * t) / l)) * Math.Sin((k * Math.PI * x) / l);
                k++;
            } while (k <=25);

            sol = sum/1.20;
        }

        public double g(double m)
        {
            return 1.0;
        }

        public double f(double m)
        {
            return (-m/20.0)*(m-l);
        }
    }
}
