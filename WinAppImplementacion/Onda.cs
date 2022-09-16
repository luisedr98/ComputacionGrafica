using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppImplementacion
{
    internal class Onda:Vector
    {
        double w, t, v, m;
        Color apagado;
        public Onda(PictureBox pb, double w, double t, double v, double m): base(pb)
        {
            this.apagado = pb.BackColor;
            this.t = t;
            this.v = v;
            this.m = m;
            this.w = w;
        }


        public Bitmap graf(Color[] paleta)
        {
            double x, y, z;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    x = VRealx(i);
                    y = VRealy(j);
                    z = w * Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) - v * t;
                    z = m * Math.Sin(z) + 1;
                    int color = (int)(z * 7.5);
                    Color c = paleta[color];
                    base.Encender(i, j, c);
                }
            }
            return bmp;
        }

        public Bitmap interferencia(Color[] paleta)
        {
            
            double x, y, z, z2, z3, z4;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {                                                                              
                    x = VRealx(i);
                    y = VRealy(j);

                    z = w * Math.Sqrt(Math.Pow((x - 0), 2) + Math.Pow((y - 2), 2)) - v * t; // 1ra fuente
                    z2 = w * Math.Sqrt(Math.Pow((x - 0), 2) + Math.Pow((y + 6), 2)) - v * t; // 2da fuente
                    z3 = w * Math.Sqrt(Math.Pow((x) - ((Math.Sqrt(3) * 8) / 2), 2) + Math.Pow((y + 2), 2)) - v * t; // 3ra fuente
                    z = Math.Sin(z) + 1;
                    z2 = Math.Sin(z2) + 1;
                    z3 = Math.Sin(z3) + 1;
                    z = z + z2 + z3;
                    int color = (int)(z * 2.50);
                    Color c = paleta[color];
                    base.Encender(i, j, c);
                }
            }
            return bmp;
        }

        public Bitmap hyugens(Color [] paleta)
        {
            double x, y, z, z2;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    x = VRealx(i);
                    y = VRealy(j);
                    z = 0;
                    for (int l = 0; l <=13; l++)
                    {
                        z2 = w * Math.Sqrt(Math.Pow(x - 6 + l, 2) + Math.Pow(y, 2)) - v * t;
                        z = m * Math.Sin(z2) + z;
                    }
                    int c = (int)((13 + z) * (15.0 / 26.0));
                    Color color = paleta[c];
                    base.Encender(i, j, color);
                }
            }
            return bmp;
        }

        public Bitmap Apagar(PictureBox pantalla)
        {
            if (pantalla.Image == null)
            {
                bmp = new Bitmap(700, 420);
            }
            else bmp = new Bitmap(pantalla.Image);
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    base.Encender(i, j, apagado);
                }
            }
            return bmp;
        }

    }
}
