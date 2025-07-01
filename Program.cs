using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Tarea_Calculadora
{
    internal class Program
    {
        private static doble lresutado;
        private static doble Operaciones;
        private static doble IsPostBack;
        private static doble Button;
        

        protected void Page_Load(object sender, EventArgs e)
            {
                if (IsPostBack)
                    return;
                    Operaciones.Limpiar();
            }

            protected void Digito_Click(object sender, EventArgs e)
            {
                Button btn = (Button)sender;
                Operaciones.valor += btn.Text;
                lresutado.Text = Operaciones.valor;
            }

            protected void bsuma_Click(object sender, EventArgs e)
            {
                float.TryParse(lresutado.Text, out Operaciones.num1);
                Operaciones.valor = "";
                Operaciones.suma = true;
                lresutado.Text = "";
            }

            protected void bresta_Click(object sender, EventArgs e)
            {
                float.TryParse(lresutado.Text, out Operaciones.num1);
                Operaciones.valor = "";
                Operaciones.resta = true;
                lresutado.Text = "";
            }

            protected void bigual_Click(object sender, EventArgs e)
            {
                float.TryParse(lresutado.Text, out Operaciones.num2);
                if (Operaciones.suma)
                    Operaciones.total = Operaciones.num1 + Operaciones.num2;
                else if (Operaciones.resta)
                    Operaciones.total = Operaciones.num1 - Operaciones.num2;

                lresutado.Text = Operaciones.total.ToString();
                Operaciones.Limpiar();
            }

            protected void bcuadrado_Click(object sender, EventArgs e)
            {
                if (float.TryParse(lresutado.Text, out float num))
                    lresutado.Text = Operaciones.PotenciaCuadrado(num).ToString();
            }

            protected void bcubo_Click(object sender, EventArgs e)
            {
                if (float.TryParse(lresutado.Text, out float num))
                    lresutado.Text = Operaciones.PotenciaCubo(num).ToString();
            }

            protected void braiz_Click(object sender, EventArgs e)
            {
                if (float.TryParse(lresutado.Text, out float num))
                {
                    try
                    {
                        lresutado.Text = Operaciones.RaizCuadrada(num).ToString();
                    }
                    catch (Exception ex)
                    {
                        lresutado.Text = ex.Message;
                    }
                }
            }

            protected void bfactorial_Click(object sender, EventArgs e)
            {
                if (int.TryParse(lresutado.Text, out int num))
                {
                    try
                    {
                        lresutado.Text = Operaciones.Factorial(num).ToString();
                    }
                    catch (Exception ex)
                    {
                        lresutado.Text = ex.Message;
                    }
                }
            }

            protected void bfibonacci_Click(object sender, EventArgs e)
            {
                if (int.TryParse(lresutado.Text, out int num))
                {
                    try
                    {
                        lresutado.Text = Operaciones.Fibonacci(num);
                    }
                    catch (Exception ex)
                    {
                        lresutado.Text = ex.Message;
                    }
                }
            }

         
        }
    }

    

