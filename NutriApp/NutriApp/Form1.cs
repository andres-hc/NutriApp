using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int peso = Convert.ToInt32(pesoTxt.Text);
            decimal talla = Convert.ToDecimal(tallaTxt.Text);
            int cintura = Convert.ToInt32(cinturaTxt.Text);
            int cefalico = Convert.ToInt32(cefalicoTxt.Text);

            //Formula para calcular IMC
            decimal imc = Decimal.Round(peso / (talla * talla),2);
            imcTxt.Text = Convert.ToString(imc);
            
            //Formula para calcular Cintura
            

            //Formula para diagnosticar la cabeza
        }
    }
}
