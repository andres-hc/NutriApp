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
            double peso = Convert.ToDouble(pesoTxt.Text);
            double talla = Convert.ToDouble(tallaTxt.Text);
            String cintura = Convert.ToString(cinturaTxt.Text);
            double cefalico = Convert.ToDouble(cefalicoTxt.Text);

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
                    if (genero == masc && cin > 94 || genero == fem && cin > 80)
                    {
                        diagCinturaTxt.Text = normal;
                    }
                    else
                    {
                        if (genero == masc && cin > 93.99 && cin < 102 ||
                            genero == fem && cin > 79.99 && cin < 88)
                        {
                            diagCinturaTxt.Text = riesgoA;
                        }
                        else
                        {
                            if (genero == masc && cin > 109.99 || genero == fem && cin > 87.99)
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
