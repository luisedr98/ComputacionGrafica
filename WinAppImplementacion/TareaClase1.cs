namespace WinAppImplementacion
{
    public partial class TareaClase1 : Form
    {
        Circunferencia roja;
        Lazo negro;
        Segmento s;
        Vector v;
        Raiz r;
        public TareaClase1()
        {
            InitializeComponent();
        }

        private void FormPixel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            v = new Vector(PbxPantalla);

            s = new Segmento(-10,10,0, 0, PbxPantalla);
            PbxPantalla.Image = s.Encender(Color.Black);


            roja = new Circunferencia(1,1, 3, PbxPantalla);
            PbxPantalla.Image = roja.Encender(Color.Red);

            negro = new Lazo(1, 2, 3, PbxPantalla);
            PbxPantalla.Image = negro.Encender(Color.Green);


            r = new Raiz(3,2,1, PbxPantalla);
            PbxPantalla.Image = r.Encender(Color.Black);

        }

        private void BtnApagarCirculo_Click(object sender, EventArgs e)
        {
            PbxPantalla.Image= s.Apagar(PbxPantalla);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PbxPantalla.Image = roja.Apagar(PbxPantalla);
        }

        private void BtnApagarLazo_Click(object sender, EventArgs e)
        {
            PbxPantalla.Image = r.Apagar(PbxPantalla);
        }

        private void BtnOffLazo_Click(object sender, EventArgs e)
        {
            PbxPantalla.Image = negro.Apagar(PbxPantalla);
        }
    }
}