namespace Atvd_Calculadora
{
    public partial class Form1 : Form
    {
        double numero01, numero02, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numero01 = Convert.ToDouble(Numero01.Text);
            numero02 = Convert.ToDouble(Numero02.Text);

            resultado = numero01 + numero02;

            labelResultado.Text = resultado.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numero01 = Convert.ToDouble(Numero01.Text);
            numero02 = Convert.ToDouble(Numero02.Text);

            resultado = numero01 - numero02;

            labelResultado.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numero01 = Convert.ToDouble(Numero01.Text);
            numero02 = Convert.ToDouble(Numero02.Text);

            resultado = numero01 / numero02;

            labelResultado.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numero01 = Convert.ToDouble(Numero01.Text);
            numero02 = Convert.ToDouble(Numero02.Text);

            resultado = numero01 * numero02;

            labelResultado.Text = resultado.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numero01 = Convert.ToDouble(Numero01.Text);
            numero02 = Convert.ToDouble(Numero02.Text);

            resultado = Math.Pow(numero01, numero02);

            labelResultado.Text = resultado.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numero01 = Convert.ToDouble(Numero01.Text);
            numero02 = Convert.ToDouble(Numero02.Text);

            resultado = Math.Log(numero01, numero02);

            labelResultado.Text = resultado.ToString();

        }
    }
}
