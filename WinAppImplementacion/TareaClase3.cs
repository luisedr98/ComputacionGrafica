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
    public partial class TareaClase3 : Form
    {
        public TareaClase3()
        {
            InitializeComponent();
        }

        private void BtnGraficar_Click(object sender, EventArgs e)
        {
            Segmento s = new Segmento(-10, 10, 0, 0, PbxPantalla);
            PbxPantalla.Image = s.Encender(Color.Red);
            s = new Segmento(0, 0, 5.98, -5.98, PbxPantalla);
            PbxPantalla.Image = s.Encender(Color.Red);

            Vector v = new Vector(PbxPantalla);
            double t = -8;
            do
            {
                int xo = v.PantallaSx(t);
                int yo = v.PantallaSy((-Math.Pow(t, 2) - (12 * t) - 32));
                v.Encender(xo, yo, Color.Blue);
                t = t + 0.001;
            } while (t <= -4);
            PbxPantalla.Image = v.bmp;


            t = -4;
            do
            {
                int xo = v.PantallaSx(t);
                int yo = v.PantallaSy((-Math.Pow(t, 2) - (5 * t) - 4));
                v.Encender(xo, yo, Color.Blue);
                t = t + 0.001;
            } while (t <= -1);
            PbxPantalla.Image = v.bmp;

            t = -1;
            do
            {
                int xo = v.PantallaSx(t);
                int yo = v.PantallaSy((-Math.Pow(t, 2) + 1));
                v.Encender(xo, yo, Color.Blue);
                t = t + 0.001;
            } while (t <= 1);
            PbxPantalla.Image = v.bmp;

            t = 1;
            do
            {
                int xo = v.PantallaSx(t);
                int yo = v.PantallaSy((-Math.Pow(t, 2) + (3 * t) - 2));
                v.Encender(xo, yo, Color.Blue);
                t = t + 0.001;
            } while (t <= 2);
            PbxPantalla.Image = v.bmp;



            float radio = 0.3f;
            //t = -3;
            Circunferencia c;
            //Lazo l;
            //Raiz r;
            //do
            //{
            //    double xo = (t);
            //    double yo = ((-Math.Pow(t, 2) + (5 * t) + 24) / 6.2);
            //    c = new Circunferencia(xo, yo, radio, PbxPantalla);
            //    PbxPantalla.Image = c.Encender(Color.Green);
            //    PbxPantalla.Refresh();
            //    Thread.Sleep(5);
            //    PbxPantalla.Image = c.Apagar(PbxPantalla);
            //    t = t + 0.1;
            //    c = null;
            //} while (t <= 8);

            t = -8;
            do
            {
                double xo = (t);
                double yo = ((-Math.Pow(t, 2) - (12 * t) -32));
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
                double yo = ((-Math.Pow(t, 2) - (5 * t) - 4));
                c = new Circunferencia(xo, yo, radio, PbxPantalla);
                PbxPantalla.Image = c.Encender(Color.Green);
                PbxPantalla.Refresh();
                Thread.Sleep(5);
                PbxPantalla.Image = c.Apagar(PbxPantalla);
                t = t + 0.1;
                c = null;
            } while (t <= -1);

            t = -1;
            do
            {
                double xo = (t);
                double yo = ((-Math.Pow(t, 2) + 1));
                c = new Circunferencia(xo, yo, radio, PbxPantalla);
                PbxPantalla.Image = c.Encender(Color.Green);
                PbxPantalla.Refresh();
                Thread.Sleep(5);
                PbxPantalla.Image = c.Apagar(PbxPantalla);
                t = t + 0.1;
                c = null;
            } while (t <= 1);

            t = 1;
            do
            {
                double xo = (t);
                double yo = ((-Math.Pow(t, 2) + (3*t)- 2));
                c = new Circunferencia(xo, yo, radio, PbxPantalla);
                PbxPantalla.Image = c.Encender(Color.Green);
                PbxPantalla.Refresh();
                Thread.Sleep(5);
                PbxPantalla.Image = c.Apagar(PbxPantalla);
                t = t + 0.1;
                c = null;
            } while (t <= 2);



        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
