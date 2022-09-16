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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnInterpolar_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(700, 420);
            //for (int i = 0; i < 700; i++)
            //{
            //    for (int j = 0; j < 420; j++)
            //    {


            //            int r = ((255 * (j - 420)) / -420) + ((240 * (j)) / 420);
            //            int g = ((165 * (j - 420)) / -420) + ((230 * (j)) / 420);
            //            int b = (140 * (j)) / 420;
            //            bmp.SetPixel(i, j, Color.FromArgb(r, g, b));



            //    }
            //}
            //PbxPantalla.Image = bmp;


            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    if (j <= 210)
                    {
                        int r = (int)((255 * (j - 210)) / (-210));
                        int g = (int)((255 * (j - 210)) / (-210));
                        int b = (int)((255 * j) / (210));
                        bmp.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                    else
                    {
                        int r = (255 * (j - 210)) / 210;
                        int g = 0;
                        int b = (255 * (j - 420)) / -210;
                        bmp.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }


                }
            }
            PbxPantalla.Image = bmp;
            //PbxPantalla.Refresh();
            //BtnBillar.PerformClick();

        }

        private void BtnInterpolarHorizontal_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(700, 420);
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    int r = ((255 * (i - 700)) / -700) + ((240 * (i)) / 700);
                    int g = ((165 * (i - 700)) / -700) + ((230 * (i)) / 700);
                    int b = (140 * (i)) / 700;
                    bmp.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            PbxPantalla.Image = bmp;

        }

        private void BnEjes3D_Click(object sender, EventArgs e)
        {
            Color c = Color.Blue;
            Segmento3D s = new Segmento3D(0, 0, 0, 0, 0, 5, PbxPantalla);
            PbxPantalla.Image = s.Encender(c);
            s = new Segmento3D(0, 0, 0, 5, 0, 0, PbxPantalla);
            PbxPantalla.Image = s.Encender(c);
            s = new Segmento3D(0, 8, 0, 0, 0, 0, PbxPantalla);
            PbxPantalla.Image = s.Encender(c);

            //ejes 8
            s = new Segmento3D(0, 8, 0, 0, 5, 5, PbxPantalla);
            PbxPantalla.Image = s.Encender(c);
            //eje 9
            s = new Segmento3D(8, 8, 0, 0, 0, 5, PbxPantalla);
            PbxPantalla.Image = s.Encender(c);
            //eje 4
            s = new Segmento3D(8, 8, 0, 5, 0, 0, PbxPantalla);
            PbxPantalla.Image = s.Encender(c);
            //eje 5
            s = new Segmento3D(0, 8, 5, 5, 0, 0, PbxPantalla);
            PbxPantalla.Image = s.Encender(c);
            //eje 7
            s = new Segmento3D(0, 0, 0, 5, 5, 5, PbxPantalla);
            PbxPantalla.Image = s.Encender(c);
            //eje 6
            s = new Segmento3D(0, 0, 5, 5, 0, 5, PbxPantalla);
            PbxPantalla.Image = s.Encender(c);
        }

        private void BtnSuperficie3D_Click(object sender, EventArgs e)
        {
            Vector3D v = new Vector3D(PbxPantalla);
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
            } while (t <= 5);
            PbxPantalla.Image = v.bmp;
        }

        private void BtnResorte_Click(object sender, EventArgs e)
        {
            Vector3D v = new Vector3D(PbxPantalla);
            double Xo, Yo, Zo;
            double h = 0;
            do
            {
                //tiene dos de radio 
                //la primera coordena en X es la pos 
                //la primera coordena en Y es la pos
                Xo = 1 + 2 * Math.Cos(h);
                Yo = 2 + 2 * Math.Sin(h);
                Zo = -4 + (h / 30); //separación entre cada vuelta (helongacion)

                v.Encender(Xo, Yo, Zo, Color.Red);
                h = h + 0.02;
            } while (h <= 30); //numero de vueltas
            PbxPantalla.Image = v.Grafico();
        }

        private void BtnTiroParabolico_Click(object sender, EventArgs e)
        {
            Circunferencia c;
            Vector v = new Vector(PbxPantalla);
            //double t = -2.8;
            //do
            //{
            //    int xo = v.PantallaSx(t);
            //    int yo = v.PantallaSy(1 / (t + 3));
            //    v.Encender(xo, yo, Color.Blue);
            //    t = t + 0.001;
            //} while (t <= 10);
            //PbxPantalla.Image = v.bmp;


            //t = -2;
            //do
            //{
            //    int xo = v.PantallaSx(t);
            //    int yo = v.PantallaSy((1.0 / 3.0) - ((t / 9)) + ((Math.Pow(t, 2) / 27)));
            //    v.Encender(xo, yo, Color.Red);
            //    t = t + 0.001;
            //} while (t <= 10);
            //PbxPantalla.Image = v.bmp;


            double t = -4;
            do
            {
                int xo = v.PantallaSx(t);
                int yo = v.PantallaSy(((-Math.Pow(t, 2) - (3 * t) + 4) / 1.11));
                v.Encender(xo, yo, Color.Blue);
                t = t + 0.001;
            } while (t <= 1);
            PbxPantalla.Image = v.bmp;
            t = -8;

            double radio = 0.2;
            do
            {
                double xo = (t);
                double yo = (((-Math.Pow(t, 2) - (12 * t) - 32)));
                c = new Circunferencia(xo, yo, radio, PbxPantalla);
                PbxPantalla.Image = c.Encender(Color.Green);
                PbxPantalla.Refresh();
                Thread.Sleep(5);
                PbxPantalla.Image = c.Apagar(PbxPantalla);
                t = t + 0.1;
                c = null;

            } while (t <= -4);

            t = -4;

            do
            {
                double xo = (t);

                double yo = (((-Math.Pow(t, 2) - (3 * t) + 4) / 1.11));
                c = new Circunferencia(xo, yo, radio, PbxPantalla);
                PbxPantalla.Image = c.Encender(Color.Green);
                PbxPantalla.Refresh();
                Thread.Sleep(5);
                PbxPantalla.Image = c.Apagar(PbxPantalla);
                t = t + 0.1;
                c = null;
            } while (t <= 1);
        }

        private void BtnEjes2D_Click(object sender, EventArgs e)
        {
            Segmento s = new Segmento(-10, 10, 0, 0, PbxPantalla);
            PbxPantalla.Image = s.Encender(Color.Red);
            s = new Segmento(0, 0, 5.98, -5.98, PbxPantalla);
            PbxPantalla.Image = s.Encender(Color.Red);
        }

        private void PbxPantalla_Click(object sender, EventArgs e)
        {

        }

        private void BtnBillar_Click(object sender, EventArgs e)
        {
          

            double t = -7;
            double radio = 0.6;
            Vector v = new Vector(PbxPantalla);


            do
            {
                double xo = (t);
                double yo = (6.0 / 5.0 * t) + (27.0 / 5.0);
                int vxo = v.PantallaSx(xo);
                int vyo = v.PantallaSy(yo);
                v.Encender(vxo, vyo, Color.Red);
                t = t + 0.001;
            } while (t <= -2);
            PbxPantalla.Image = v.bmp;

            t = -2;
            do
            {
                double xo = (t);
                double yo = ((-Math.Pow(t, 2) + (2 * t) + 8)) / 4.5 + 3;
                int vxo = v.PantallaSx(xo);
                int vyo = v.PantallaSy(yo);
                v.Encender(vxo, vyo, Color.Red);
                t = t + 0.001;
            } while (t <= 4);
            PbxPantalla.Image = v.bmp;


            Circunferencia c;
            t = -7;
            radio = 0.6;
            do
            {
                double xo = (t);
                double yo = (1.2 * t) + 5.4;
                c = new Circunferencia(xo, yo, radio, PbxPantalla);
                PbxPantalla.Image = c.Encender(Color.Green);
                PbxPantalla.Refresh();
                Thread.Sleep(5);
                PbxPantalla.Image = c.Apagar(PbxPantalla);
                t = t + 0.1;
                c = null;
            } while (t <= -2);


            t = -2;
            radio = 0.6;
            do
            {
                double xo = (t);
                double yo = ((-Math.Pow(t, 2) + (2 * t) + 8)) / 4.5 + 3;
                c = new Circunferencia(xo, yo, radio, PbxPantalla);
                PbxPantalla.Image = c.Encender(Color.Green);
                PbxPantalla.Refresh();
                Thread.Sleep(5);
                PbxPantalla.Image = c.Apagar(PbxPantalla);
                t = t + 0.1;
                c = null;
            } while (t <= 4);



        }

        private void BtnCirculo_Click(object sender, EventArgs e)
        {
            Circunferencia c;
            c = new Circunferencia(0, 0, 5, PbxPantalla);
            PbxPantalla.Image = c.Encender(Color.Red);

            double t = 0;
            double dt = 0.002;
            do
            {
                int x = (int)(0 + 3.5 * Math.Cos((double)t));
                int y = (int)(0 + 3.5 * Math.Sin((double)t));


                t = t + dt;
            } while (t <= (2 * Math.PI));
            c = new Circunferencia(0, 0, 2, PbxPantalla);
            PbxPantalla.Image = c.Encender(Color.Green);

        }

        private void BtnOndas_Click(object sender, EventArgs e)
        {
            Paleta p = new Paleta();

            double m = 1;
            double w = 1.5; //inversamente proporcional a la longitud de onda
            double v = 9.3;
            double t = 0;
            Onda o = new Onda(PbxPantalla, w, t, v, m);
            PbxPantalla.Image = o.graf(p.paleta4);
            //PbxPantalla.Image = o.apagar();
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            PbxPantalla.Image = null;
        }

        private void BtnOnda3D_Click(object sender, EventArgs e)
        {
 
            double m = 0.3;
            double w = 2.5; //inversamente proporcional a la longitud de onda
            double v = 9.3;
            double t = 0;
            double dt = 0.5;
            do
            {
                Onda3D onda3d = new Onda3D(PbxPantalla, w, t, v, m);
                onda3d.graf3D(Color.Red);
                PbxPantalla.Image = onda3d.Grafico();
                PbxPantalla.Refresh();
                Thread.Sleep(250);
                PbxPantalla.Image = null;
                onda3d = null;
                t = dt + t;
            } while (t <= 8);
           
 


        }

        private void BtnSnimacion_Click(object sender, EventArgs e)
        {

            Paleta p = new Paleta();

            double m = 1;
            double w = 1.5; //inversamente proporcional a la longitud de onda
            double v = 9.3;
            double t = 0;

            double tp = 0;
            double dtp = 0.80;

            //do
            //{
            //    Onda o = new Onda(PbxPantalla, w, tp, v, m);
            //    PbxPantalla.Image = o.hyugens(p.paleta3);
            //    PbxPantalla.Refresh();
            //    tp = tp + dtp;
            //    o = null;
            //} while (tp <= 20);

            Onda o = new Onda(PbxPantalla, w, tp, v, m);
            PbxPantalla.Image = o.interferencia(p.paleta);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m = 0.3;
            double w = 2.5; //inversamente proporcional a la longitud de onda
            double v = 9.3;
            double t = 0;
            double dt = 0.5;
            do
            {
                Onda3D onda3d = new Onda3D(PbxPantalla, w, t, v, m);
                onda3d.fuente3D(Color.Red);
                PbxPantalla.Image = onda3d.Grafico();
                PbxPantalla.Refresh();
                Thread.Sleep(250);
                PbxPantalla.Image = null;
                onda3d = null;
                t = dt + t;
            } while (t <= 8);
        }

        private void BtnFenInterpolado_Click(object sender, EventArgs e)
        {
            Vector v = new Vector(PbxPantalla);
            double t = -7;
            do
            {
                if (t <= -2)
                {
                    int x = v.PantallaSx(t);
                    int y = v.PantallaSy((6.0 / 5.0)* t + (27.0 / 5.0)); 
                    v.Encender(x, y, Color.Red);

                }
                else
                {
                    int x = v.PantallaSx(t); 
                    double form = ((1.0 / 6.0) * ((t - 1) * (t - 4))) - ((5.0 / 9.0) * ((t + 2) * (t - 4))) + ((1.0 / 6.0) * ((t + 2) * (t - 1)));
                    int y = v.PantallaSy(form);
                    v.Encender(x, y, Color.Red);
                }
                t = t + 0.001;
            } while (t <= 4);
            PbxPantalla.Image = v.bmp;

            //animacion del circulo
            t = -7;
            Circunferencia c;
            double radio = 0.4;
            do
            {
                if (t <= -2)
                {
                    double  x = (t);
                    double y = ((6.0 / 5.0) * t + (27.0 / 5.0)); //sigue la trayectoria de la recta
                    c = new Circunferencia(x, y, radio, PbxPantalla);
                    PbxPantalla.Image = c.Encender(Color.Green);
                    PbxPantalla.Refresh();
                    Thread.Sleep(5);
                    PbxPantalla.Image = c.Apagar(PbxPantalla);
                }
                else
                {
                    double x = (t);
                    double form = ((1.0 / 6.0) * ((t - 1) * (t - 4))) - ((5.0 / 9.0) * ((t + 2) * (t - 4))) + ((1.0 / 6.0) * ((t + 2) * (t - 1)));
                    c = new Circunferencia(x, form, radio, PbxPantalla);
                    PbxPantalla.Image = c.Encender(Color.Green);
                    PbxPantalla.Refresh();
                    Thread.Sleep(5);
                    PbxPantalla.Image = c.Apagar(PbxPantalla);
                }
                c = null;
                t = t + 0.1;
            } while (t <= 4);
        }

        private void Circulos_Click(object sender, EventArgs e)
        {
            Circunferencia c;
            c = new Circunferencia(-7, -3, 0.4, PbxPantalla);
            PbxPantalla.Image = c.Encender(Color.Green);
            c = new Circunferencia(-2, 3, 0.4, PbxPantalla);
            PbxPantalla.Image = c.Encender(Color.Green);
            c = new Circunferencia(1, 5, 0.4, PbxPantalla);
            PbxPantalla.Image = c.Encender(Color.Green);
            c = new Circunferencia(4, 3, 0.4, PbxPantalla);
            PbxPantalla.Image = c.Encender(Color.Green);
        }

        private void CuerdavBtn_Click(object sender, EventArgs e)
        {
            double l = 5;
            double c = 0.5;
            //CuerdaV  v = new CuerdaV(PbxPantalla,1,l,c);
            //v.Grafico(Color.Red);
            //PbxPantalla.Image = v.Grafico();
            CuerdaV v;
            double t = 1, dt = 0.2;
            do
            {
                v = new CuerdaV(PbxPantalla, t, l, c);
                v.Grafico(Color.Red);
                PbxPantalla.Image = v.Grafico();
                PbxPantalla.Refresh();
                Thread.Sleep(90);
                PbxPantalla.Image = null;
                t = t + dt;
            } while (t <= 12);
        }
    }
}