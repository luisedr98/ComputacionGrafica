using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppImplementacion
{
    internal class Vector3D : Vector
    {

        double angulo;
        Color apagado;
      

        public Vector3D(PictureBox pb) : base(pb)
        {
            this.angulo = Math.PI / 4;
            apagado = pb.BackColor;
        }

        public double AsometriaX(double x, double y)
        {
            return y - (x / 2) * Math.Cos(angulo);
        }

        public double AsometriaY(double x, double z)
        {
            return z - (x / 2) * Math.Sin(this.angulo);
        }

        public void Encender(double x,double y,double z,Color c)
        {
            int xo = PantallaSx(this.AsometriaX(x,y)); 
            int yo = PantallaSy(this.AsometriaY(x,z));
            bmp.SetPixel(xo, yo, c);
        }

        public void Apagar(double x, double y, double z)
        {
            Encender(x,y,z,this.apagado);
        }
    }
}
