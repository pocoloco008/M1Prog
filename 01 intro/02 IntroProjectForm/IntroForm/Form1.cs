using System.Security.Cryptography.X509Certificates;

namespace IntroForm
{
    public partial class Form1 : Form
    {
        //ken waardes toe aan de variabelen (assignement (=))
        int x = 150;// iets van tussen de 50 en 300
        int y = 150;// iets van tussen de 50 en 300
        string introSentence = "fucking";
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            g.DrawString(introSentence, Font, Brushes.Black, x, y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
