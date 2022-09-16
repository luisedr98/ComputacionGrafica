using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppImplementacion
{
    internal class Vector
    {
        public Bitmap bmp;
        private Color apagado;

        //variables ecuaciones
        int Sx1, Sx2, Sy1, Sy2;
        double y1, y2, x1, x2, x, y;
        //incializacion de los valores
        public Vector(PictureBox pantalla)
        {
            apagado = pantalla.BackColor;
            Sx1 = 0;
            Sx2 = 700;
            Sy1 = 0;
            Sy2 = 420;
            x1 = -10;
            x2 = 10;
            y1 = -5.98;
            y2 = 5.98;

            if (pantalla.Image == null)
            {
                bmp = new Bitmap(700, 420);
            }
            else bmp = new Bitmap(pantalla.Image);

        }



        public int PantallaSy(double Yo)
        {
            int posy = (int)(((Yo - y2) / (y2 - y1)) * (Sy1 - Sy2)) + Sy1;
            return posy;
            
        }


        public int PantallaSx(double Xo)
        {
            int posx = (int)(((Xo - x1) / (x1 - x2)) * (Sx1 - Sx2)) + Sx1;
            return posx;
        }

        public int Sr(double r)
        {
            double num = this.x1 - r;
            return this.PantallaSx(num);
        }

        public void Encender(int x, int y, Color color)
        {
             bmp.SetPixel(x, y, color); 
        }

        public double VRealy(int Sy)
        {
           return ((y2 - y1) * (Sy - Sy1) / (Sy1 - Sy2)) + y2;
        }

        public double VRealx(int Sx)
        {
           return ((x1 - x2) * (Sx - Sx1) / (Sx1 - Sx2)) + x1;
        }

        public Bitmap Grafico()
        {
            return bmp;
        }

        public void Apagar(int x, int y)
        {
            bmp.SetPixel(x, y, apagado);
        }
    }

}