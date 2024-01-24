using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculadora
{ 
    public partial class Form1 : Form
    {
        public double Expoente
        {
            get;
            set;
        }


        public double Armazena
        {
            get;
            set;
        }

        public double Menos
        {
            get;
            set;
        }
        public double Vezes
        {
            get;
            set;
        }
        public double Dividir
        {
            get;
            set;
        }
        public double Pow
        {
            get;
            set;
        }
        public double Raiz
        {
            get;
            set;
        }
        public double Porcentagem
        {
            get;
            set;
        }
        public double soma 
        {  
            get;
            set; 
        }

        public double Verificador 
        {  
            get; 
            set; 
        }

        List<double> Valores_Armazenados = new List<double>();

        double selecionaoperacao 
        { 
            get; 
            set; 
        }

        public double Valor 
        { 
            get; 
            set; 
        }

        public Form1()
        {
            InitializeComponent();
        }
                
        private void btn_um_Click(object sender, EventArgs e)
        {
            tbx_conta.Text += "1";
        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            tbx_conta.Text += "2";
        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            tbx_conta.Text += "3";
        }

        private void btn_quatro_Click(object sender, EventArgs e)
        {
            tbx_conta.Text += "4";
        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            tbx_conta.Text += "5";
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            tbx_conta.Text += "6";
        }

        private void btn_sete_Click(object sender, EventArgs e)
        {
            tbx_conta.Text += "7";
        }

        private void btn_oito_Click(object sender, EventArgs e)
        {
            tbx_conta.Text += "8";
        }

        private void btn_nove_Click(object sender, EventArgs e)
        {
            tbx_conta.Text += "9";
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            tbx_conta.Text += ",";
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            tbx_conta.Text += "0";
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tbx_conta.Text = "";
            tbx_resultado.Text = "";
            Valor = 0;
            Valores_Armazenados.Clear();
        }

        private void btn_mais_Click(object sender, EventArgs e)
        {
            selecionaoperacao = 1;
            Valor = Convert.ToDouble(tbx_conta.Text);
            Valores_Armazenados.Add(Valor);
            tbx_conta.Text = "";
            if (tbx_resultado.Text != "")
            {
                tbx_conta.Text = tbx_resultado.Text;
                tbx_resultado.Text = "";
                Valores_Armazenados.Clear();
                Valores_Armazenados.Add(Convert.ToDouble(tbx_conta.Text));
                tbx_conta.Text = "";
            }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            selecionaoperacao = 2;
            Valor = Convert.ToDouble(tbx_conta.Text);
            Valores_Armazenados.Add(Valor);
            tbx_conta.Text = "";
            if (tbx_resultado.Text != "")
            {
                tbx_conta.Text = tbx_resultado.Text;
                tbx_resultado.Text = "";
                Valores_Armazenados.Clear();
                Valores_Armazenados.Add(Convert.ToDouble(tbx_conta.Text));
                tbx_conta.Text = "";
            }
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            selecionaoperacao = 3;
            Valor = Convert.ToDouble(tbx_conta.Text);
            Valores_Armazenados.Add(Valor);
            tbx_conta.Text = "";
            if (tbx_resultado.Text != "")
            {
                tbx_conta.Text = tbx_resultado.Text;
                tbx_resultado.Text = "";
                Valores_Armazenados.Clear();
                Valores_Armazenados.Add(Convert.ToDouble(tbx_conta.Text));
                tbx_conta.Text = "";
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            selecionaoperacao = 4;
            Valor = Convert.ToDouble(tbx_conta.Text);
            Valores_Armazenados.Add(Valor);
            tbx_conta.Text = "";

        }

        private void btn_pow_Click(object sender, EventArgs e)
        {
            selecionaoperacao = 5;
            Valor = Convert.ToDouble(tbx_conta.Text);
            tbx_conta.Text = "";
            Valores_Armazenados.Add(Valor);
            if (tbx_resultado.Text != "")
            {
                tbx_conta.Text = tbx_resultado.Text;
                tbx_resultado.Text = "";
                Valores_Armazenados.Clear();
                Valores_Armazenados.Add(Convert.ToDouble(tbx_conta.Text));
                tbx_conta.Text = "";
            }
        }

        private void btn_raiz_Click(object sender, EventArgs e)
        {
            selecionaoperacao = 6;
            if (tbx_resultado.Text != "")
            {
                tbx_conta.Text = tbx_resultado.Text;
                tbx_resultado.Text = "";
                Valores_Armazenados.Clear();
                Valores_Armazenados.Add(Convert.ToDouble(tbx_conta.Text));
                //tbx_conta.Text = "";
            }

        }

        private void btn_porcento_Click(object sender, EventArgs e)
        {
            selecionaoperacao = 7;
            Valor = Convert.ToDouble(tbx_conta.Text);
            tbx_conta.Text = "";
            Valores_Armazenados.Add(Valor);
            if (tbx_resultado.Text != "")
            {
                tbx_conta.Text = tbx_resultado.Text;
                tbx_resultado.Text = "";
                Valores_Armazenados.Clear();
                Valores_Armazenados.Add(Convert.ToDouble(tbx_conta.Text));
                tbx_conta.Text = "";
            }
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            Valor = Convert.ToDouble(tbx_conta.Text);
            Valores_Armazenados.Add(Valor);

            if (selecionaoperacao == 1)
            {
                Armazena = 1;
                soma = Valores_Armazenados.Sum();
                tbx_resultado.Text = soma.ToString();
            }

            else if (selecionaoperacao == 2)
            {

                Menos = Valores_Armazenados.Aggregate((acumulado, atual) => acumulado - atual);
                tbx_resultado.Text = Menos.ToString();
            }

            else if (selecionaoperacao == 3)
            {
                Vezes = Valores_Armazenados.Aggregate((acumulado, atual) => acumulado * atual);
                tbx_resultado.Text = Vezes.ToString();
            }

            else if (selecionaoperacao == 4)
            {
                Dividir = Valores_Armazenados.Aggregate((acumulado, atual) => acumulado / atual);
                tbx_resultado.Text = Dividir.ToString();
            }

            else if ((selecionaoperacao == 5))
            {
                tbx_resultado.Text = Math.Pow(Valores_Armazenados.First(), Valor).ToString();
                Valores_Armazenados.Clear();
            }

            else if (selecionaoperacao == 6)
            {
                Valor = Convert.ToDouble(tbx_conta.Text);
                Raiz = Math.Sqrt(Valor);
                tbx_resultado.Text = Raiz.ToString();
                
            }
            else if (selecionaoperacao == 7)
            {
                double De = Valores_Armazenados.First(); // Usar o último valor adicionado à lista
                Porcentagem = (De * Valor) / 100;
                tbx_resultado.Text = Porcentagem.ToString();
                Valores_Armazenados.Clear();
            }
        }

    }
}
