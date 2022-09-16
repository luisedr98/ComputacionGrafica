using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppImplementacion
{
    internal class Circunferencia: Vector
    {
        int Xo;
        int Yo;
        double Radio;
        double t;
        double dt;
        Color apagado;


        public Circunferencia(double Xo, double Yo, double Radio, PictureBox pb) : base(pb)
        {

            this.apagado = pb.BackColor;
            this.Xo = PantallaSx(Xo);
            this.Yo = PantallaSy(Yo);
            this.Radio = Sr(Radio);
        }



        public Bitmap Encender(Color c)
        {
            t = 0;
            dt = 0.002;
            do
            {
                int x = (int)(Xo + Radio * Math.Cos((double)t)); 
                int y = (int)(Yo + Radio * Math.Sin((double)t));
                base.Encender(x, y, c);
                t = t + dt;
            } while (t <= (2*Math.PI));

           return bmp;
        }


        public Bitmap Apagar(PictureBox pantalla)
        {
            if(pantalla.Image == null)
            {
                bmp = new Bitmap(700, 420);
            }
            else bmp = new Bitmap(pantalla.Image);
            return bmp = Encender(apagado);
        }
    }
}
