using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private double calcular(double n1, double n2, double n3, double n4) 
        {
            if (n1 > 10 || n2 > 10 || n3 > 10 || n4 > 10) 
            {
                MessageBox.Show("Input invalido");
                limpar();
            }
            return ((n1 + n2 + n3 + n4) / 4);
        }


        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt_n1.Text);
            double n2 = Convert.ToDouble(txt_n2.Text);
            double n3 = Convert.ToDouble(txt_n3.Text);
            double n4 = Convert.ToDouble(txt_n4.Text);

            txt_result.Text = calcular(n1, n2, n3, n4).ToString();

            MessageBox.Show(calcular(n1, n2, n3, n4).ToString());

            limpar();
            
        }

        private void limpar()
        {
            txt_n1.Text = string.Empty;
            txt_n2.Text = string.Empty;
            txt_n3.Text = string.Empty;
            txt_n4.Text = string.Empty;
            txt_result.Text = string.Empty;
            txt_n1.Focus();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja realmente sair?","Atenção", MessageBoxButtons.YesNo);
            if (sair == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                limpar();
            }

        }
    }
}
