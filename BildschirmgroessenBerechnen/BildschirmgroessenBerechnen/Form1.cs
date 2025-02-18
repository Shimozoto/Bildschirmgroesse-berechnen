namespace BildschirmgroessenBerechnen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Diagonale
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Berechnen Button
        private void button1_Click(object sender, EventArgs e)
        {
            int seitenverhaeltnisA = 0, seitenverhaeltnisB = 0;
            double diagonaleZoll = 0, hoehe, breite, diagonaleCm;
            try
            {
                diagonaleZoll = Convert.ToDouble(textBox1.Text);
                diagonaleCm = diagonaleZoll * 2.54;
            }
            catch
            {
                MessageBox.Show("Ungültige Eingabe in der Diagonalen.");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
            try
            {
                seitenverhaeltnisA = (int)Convert.ToDouble(textBox2.Text);
                seitenverhaeltnisB = (int)Convert.ToDouble(textBox3.Text);
                breite = (seitenverhaeltnisA / (Math.Sqrt(Math.Pow(seitenverhaeltnisA, 2) + (Math.Pow(seitenverhaeltnisA, 2))))) * diagonaleCm;
            }
            catch
            {
                MessageBox.Show("Fehler Bei der Berechnung, überprüfen sie ihre Eingaben.");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
                return;
            }
            try
            {
                hoehe = (seitenverhaeltnisB / (Math.Sqrt(Math.Pow(seitenverhaeltnisA, 2) + (Math.Pow(seitenverhaeltnisA, 2))))) * diagonaleCm;
            }
            catch
            {
                MessageBox.Show("Fehler Bei der Berechnung, überprüfen sie ihre Eingaben.");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
                return;
            }
            textBox4.Text = diagonaleCm.ToString("0.00");
            textBox5.Text = breite.ToString("0.00");
            textBox6.Text = hoehe.ToString("0.00");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}