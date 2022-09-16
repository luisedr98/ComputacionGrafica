using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppImplementacion
{
    public partial class TareaClase2 : Form
    {
        public TareaClase2()
        {
            InitializeComponent();
            
    }

        private void TareaClase2_Load(object sender, EventArgs e)
        {
         
        }

        private void BtnGraficar_Click(object sender, EventArgs e)
        {
            Vector3D v = new Vector3D(PbxLienzo);
            double Xo, Yo, Zo;
            double h = 0;
            do
            {
                         //tiene dos de radio
                Xo = 1 + 2 * Math.Cos(h);
                Yo = 2 + 2 * Math.Sin(h);
                Zo = -4 + (h / 5);
               
                v.Encender(Xo, Yo, Zo, Color.Red);

                h = h + 0.02;
            } while (h <= 15);
            PbxLienzo.Image = v.Grafico();
        }

        private void PbxLienzo_Click(object sender, EventArgs e)
        {
            
        }

       

        private void BtnEjes_Click(object sender, EventArgs e)
        {
            Color c = Color.Blue;
            Segmento3D s = new Segmento3D(0, 0, 0, 0, 0, 5, PbxLienzo);
            PbxLienzo.Image= s.Encender(c);
            s = new Segmento3D(0, 0, 0, 5, 0, 0, PbxLienzo);
            PbxLienzo.Image = s.Encender(c);
            s = new Segmento3D(0, 8, 0, 0, 0, 0, PbxLienzo);
            PbxLienzo.Image = s.Encender(c);

            //ejes 8
            s = new Segmento3D(0, 8, 0, 0, 5, 5, PbxLienzo);
            PbxLienzo.Image = s.Encender(c);
            //eje 9
            s = new Segmento3D(8, 8, 0, 0, 0, 5, PbxLienzo);
            PbxLienzo.Image = s.Encender(c);
            //eje 4
            s = new Segmento3D(8, 8, 0, 5, 0, 0, PbxLienzo);
            PbxLienzo.Image = s.Encender(c);
            //eje 5
            s = new Segmento3D(0, 8, 5, 5, 0, 0, PbxLienzo);
            PbxLienzo.Image = s.Encender(c);
            //eje 7
            s = new Segmento3D(0, 0, 0, 5, 5, 5, PbxLienzo);
            PbxLienzo.Image = s.Encender(c);
            //eje 6
            s = new Segmento3D(0, 0, 5, 5, 0, 5, PbxLienzo);
            PbxLienzo.Image = s.Encender(c);

            Vector3D v = new Vector3D(PbxLienzo);
            double Xo, Yo, Zo;
            double h = 0;
            do
            {
                //tiene dos de radio
                Xo = 2 + 1 * Math.Cos(h);
                Yo = 4 + 1 * Math.Sin(h);
                Zo = 0 + (h / 30);

                v.Encender(Xo, Yo, Zo, Color.Red);

                h = h + 0.002;
            } while (h <= 15);
          


            h = 0;
            do
            {
                //tiene dos de radio
                Xo = 2 + 1 * Math.Cos(h);
                Yo = 4 + 1 * Math.Sin(h);
                Zo = 2 + (h / 8);

                v.Encender(Xo, Yo, Zo, Color.Green);

                h = h + 0.002;
            } while (h <= 25);

            h = 0;
            do
            {
                //tiene dos de radio
                Xo = 2 + 0.5 * Math.Cos(h);
                Yo = -1 + 0.5 * Math.Sin(h);
                Zo = 0 + (h / 15);

                v.Encender(Xo, Yo, Zo, Color.Black);

                h = h + 0.002;
            } while (h <= 15);
            PbxLienzo.Image = v.Grafico();
        }

        private void Interpolar_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(700,420);
            for(int i = 0; i < 700; i++)
            {
                for(int j =0; j<420; j++)
                {
                    int a = 255 * (i) / 700;
                  
                    bmp.SetPixel(i, j, Color.FromArgb(a,255,0));
                }
            }
            PbxLienzo.Image = bmp;
        }

        public double Calculate(double x, Point[] coords)
        {
            int loops = coords.Length;
            double y = 0;
            double p;

            double xi, xj, yi;
            for (int i = 0; i < loops; i++)
            {
                p = 1;
                xi = coords[i].X;

                for (int j = 0; j < loops; j++)
                {
                    if (i == j)
                        continue;

                    xj = coords[j].X;

                    p *= ((x - xj) / (xi - xj));


                }
                

                yi = coords[i].Y;
                y = y + p * yi;
            }

            return y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vector3D v = new Vector3D(PbxLienzo);
            double t = -5;
            double h;
            do
            {
                h = -4;
                do
                {
                    //tiene dos de radio
                    double Xo = t;
                    double Yo = h;
                    double Zo = (0.17 * (Math.Pow(t, 2) + Math.Pow(h, 2))) - 3;
                    v.Encender(Xo, Yo, Zo, Color.Red);
                    h = h + 0.1;
                } while (h <= 4);
                t = t + 0.1;
            } while (t<= 5);
            PbxLienzo.Image = v.bmp;
        }

        private void Btninterrpolar2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(700, 420);
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    if (i <= 350)
                    {
                        int r = 255 * (i) / 350;

                        bmp.SetPixel(i, j, Color.FromArgb(r, 255, r));
                    }
                    else
                    {
                        int b = ((255 * (i - 700)) / (350-700));
                        bmp.SetPixel(i, j, Color.FromArgb(255, 255, b));
                    }
                    
                }
            }
            PbxLienzo.Image = bmp;
        }
    }
}
