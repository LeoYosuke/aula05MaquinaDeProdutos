using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula05MaquinaDeProdutos
{
    public partial class BTNcompra : Form
    {
        public BTNcompra()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNmarmita2_Click(object sender, EventArgs e)
        {
            double marmita2 = 18;
            double total = int.Parse(LBLtotalvalor.Text);
            double soma = marmita2 + total;
            LBLtotalvalor.Text = soma.ToString();
        }

        private void LBLvalor_Click(object sender, EventArgs e)
        {

        }

        private void BTNcomprar_Click(object sender, EventArgs e)
        {
            double total = int.Parse(LBLtotalvalor.Text );

            int pagar;
            pagar = int.Parse(txtdinheiro.Text);
            if(pagar >= total)
            {
                MessageBox.Show("COMPRA FINALIZADA");
            }
            else
            {
                MessageBox.Show("DINHEIRO INSUFICIENTE!!");
            }
            
            


        }

        private void BTNmarmita1_Click(object sender, EventArgs e)
        {
            double marmita1 = 16;
            double total = int.Parse(LBLtotalvalor.Text);
            double soma = marmita1 + total;
            LBLtotalvalor.Text = soma.ToString();
            
        }

        private void BTNmarmita3_Click(object sender, EventArgs e)
        {
            double marmita3 = 15;
            double total = int.Parse(LBLtotalvalor.Text);
            double soma = marmita3 + total;
            LBLtotalvalor.Text = soma.ToString();
        }

        private void BTNmarmita4_Click(object sender, EventArgs e)
        {
            double marmita4 = 20;
            double total = int.Parse(LBLtotalvalor.Text);
            double soma = marmita4 + total;
            LBLtotalvalor.Text = soma.ToString();
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            
            LBLtotalvalor.Text = Convert.ToString("0");
        }

        private void txtdinheiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBLtotalvalor_Click(object sender, EventArgs e)
        {

        }
    }
}
