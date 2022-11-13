namespace HaritaMesafeOlcer
{
    public partial class Form1 : Form
    {
        Nokta n1, n2;
        double px = 100d / 60d;

        public Form1()
        {
            InitializeComponent();
        }

        private void pboHarita_Paint(object sender, PaintEventArgs e)
        {
            if (n1 != null)
                NoktaKoy(e.Graphics, n1);

            if (n2 != null)
                NoktaKoy(e.Graphics, n2);

            if (n1 != null && n2 != null)
                CizgiCek(e.Graphics);
        }

        private void CizgiCek(Graphics g)
        {
            Pen kalem = new Pen(Color.Blue, 3f);
            g.DrawLine(kalem, n1.X, n1.Y, n2.X, n2.Y);
        }

        private void NoktaKoy(Graphics g, Nokta nokta)
        {
            Pen kalem = new Pen(Color.Blue, 6f);
            g.DrawEllipse(kalem, nokta.X - 10, nokta.Y - 10, 20, 20);
        }

        private void pboHarita_MouseClick(object sender, MouseEventArgs e)
        {
            Nokta tiklanan = new Nokta() { X = e.X, Y = e.Y };

            if (n1 == null)
            {
                n1 = tiklanan;
            }
            else
            {
                n2 = tiklanan;
                MesafeHesapla();
            }

            // her tıklamada haritayı yeniden boya
            pboHarita.Refresh();
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            n1 = n2 = null;
            lblSonuc.Text = "Haritada arasındaki mesafeyi öğrenmek istediğiniz iki noktaya sırayla tıklayınız.";
            pboHarita.Refresh();
        }

        private void MesafeHesapla()
        {
            double mesafeKm = n1.Uzaklik(n2) * px;
            lblSonuc.Text = $"Seçilen noktalar arası mesafe {mesafeKm:n0}km.";
        }
    }
}