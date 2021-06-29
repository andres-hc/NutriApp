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

        private void cinturaTxt_KeyPress(object sender,
          KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        //Validador solo numeros y ","
        private void cinturaTxt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("La cintura debe ser un entero o decimal separado por ',' Reintente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //Validador solo numeros y ","
        private void pesoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("El peso debe ser un entero o decimal separado por ',' Reintente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //Validador solo numeros y ","
        private void tallaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("La talla debe ser un entero o decimal separado por ',' Reintente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //Validador solo numeros y "-"
        private void rutTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || (e.KeyChar >= 46 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("El rut solo permite el caracter '-' como separador de DV", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        
        //Validador solo numeros y ","
        private void cefalicoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("El P.Cefalico debe ser un entero o decimal separado por ',' Reintente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void BtnCalculo_Click(object sender, EventArgs e)
        {
            String ps = pesoTxt.Text;
            String tll = tallaTxt.Text;
            String cntr = cinturaTxt.Text;
            String cflc = cefalicoTxt.Text;

            if (ps.Trim() == "" || tll.Trim() == "" || cntr.Trim() == "" || cflc.Trim() == "")
            {
                MessageBox.Show("No ha completado todos los campos, por favor ingrese informacion solicitada", "Error", MessageBoxButtons.OK);
            }
            else
            {
                double peso = Convert.ToDouble(ps);
                double talla = Convert.ToDouble(tll);
                double cintura = Convert.ToDouble(cntr);
                double cefalico = Convert.ToDouble(cflc);

                //Formula para calcular IMC
                double imc = Math.Round(peso / (talla * talla), 2);
                imcTxt.Text = Convert.ToString(imc);

                //Formula para diagnosticas Estado Nutricional
                double pI = 18.5;
                double nPI = 18.49, nPF = 25, sPI = 24.99, sPF = 27, pOI = 26.99,
                    pOF = 30, o1I = 29.99, o1F = 35, o2I = 34.99, o2F = 40, o3I = 39.99, o3F = 50, o4I = 49.99;
                String p = "Peso Insuficiente";
                String n = "Normopeso";
                String s = "Sobrepeso Grado I";
                String pre = "Preobesidad";
                String o1 = "Obesidad Tipo I";
                String o2 = "Obesidad Tipo II";
                String o3 = "Obesidad Tipo III";
                String o4 = "Obesidad Tipo IV";


                double imcD = Convert.ToDouble(imc);
                if (pI > imcD)
                {
                    estadoTxt.Text = p;
                }
                else
                {
                    if (imcD > nPI && imcD < nPF)
                    {
                        estadoTxt.Text = n;
                    }
                    else
                    {
                        if (imcD > sPI && imcD < sPF)
                        {
                            estadoTxt.Text = s;
                        }
                        else
                        {
                            if (imcD > pOI && imcD < pOF)
                            {
                                estadoTxt.Text = pre;
                            }
                            else
                            {
                                if (imcD > o1I && imcD < o1F)
                                {
                                    estadoTxt.Text = o1;
                                }
                                else
                                {
                                    if (imcD > o2I && imcD < o2F)
                                    {
                                        estadoTxt.Text = o2;
                                    }
                                    else
                                    {
                                        if (imcD > o3I && imcD < o3F)
                                        {
                                            estadoTxt.Text = o3;
                                        }
                                        else
                                        {
                                            if (imcD > o4I)
                                                estadoTxt.Text = o4;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                //Formula para diagnosticar la cabeza
                //Formulo para Diagnosticar cintura
                String sele = "--Seleccionar--";
                String masc = "Masculino";
                String fem = "Femenino";
                String normal = "Normal";
                String riesgoA = "Riesgo Alto";
                String riesgoMA = "Riesgo Muy Alto";

                double nM = 94, nF = 80, rMI = 93.99, rMF = 102, raM = 101.99, rFI = 79.99, rFF = 88, raF = 87.99;
                String genero = sexoCbx.Text;
                double cin = Convert.ToDouble(cintura);

                if (genero == sele)
                {
                    MessageBox.Show("No ha seleccionado un genero, por favor ingrese informacion solicitada", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    if (cin < 0)
                    {
                        MessageBox.Show("El valor ingresado no es correcto", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (genero == masc && cin < nM || genero == fem && cin < nF)
                        {
                            diagCinturaTxt.Text = normal;
                        }
                        else
                        {
                            if (genero == masc && cin > rMI && cin < rMF ||
                                genero == fem && cin > rFI && cin < rFF)
                            {
                                diagCinturaTxt.Text = riesgoA;
                            }
                            else
                            {
                                if (genero == masc && cin > raM || genero == fem && cin > raF)
                                {
                                    diagCinturaTxt.Text = riesgoMA;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
