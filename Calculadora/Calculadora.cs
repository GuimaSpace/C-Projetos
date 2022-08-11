using System.Globalization;

namespace asdasdasdsad
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //
            txtResultado.Text = txtResultado.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text += "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text += "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text += "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture); //Sem essa conversão a máquina ignora o ponto na conta
            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIVI")
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
            else { 
                
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture); //Sem essa conversão a máquina ignora o ponto na conta

            txtResultado.Text = ""; //Deixa o campo vazio novamente
            operacao = "SOMA";
            lblOperacao.Text = "+";

            

        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture); //Sem essa conversão a máquina ignora o ponto na conta

            txtResultado.Text = ""; //Deixa o campo vazio novamente
            operacao = "SUB";
            lblOperacao.Text = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture); //Sem essa conversão a máquina ignora o ponto na conta

            txtResultado.Text = ""; //Deixa o campo vazio novamente
            operacao = "MULT";
            lblOperacao.Text = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture); //Sem essa conversão a máquina ignora o ponto na conta

            txtResultado.Text = ""; //Deixa o campo vazio novamente
            operacao = "DIVI";
            lblOperacao.Text = "/";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text += ".";
        }
    }
}