using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            //Tratamento de erros   
            try
            {
                CalculadoraSimples calculadorasimples = new CalculadoraSimples(10 ,20);
                CalculadoraSimples calculadorasimples2 = new CalculadoraSimples(10, 23, "+");


                calculadorasimples.MostrarOperadores();
                calculadorasimples.LerValor1();
                calculadorasimples.LerValor2();
                calculadorasimples.LerOperador();

                calculadorasimples.TestarOperador();
               



                if (calculadorasimples.VerificarOperador())
                {
                    calculadorasimples.RealizarOperacao();
                    calculadorasimples.EscreverResultado();
                }

                else
                {
                    Console.WriteLine("\n Não foi possivel realizar a operação. \n\n ");
                }



            }

            catch (FormatException)
            {
                Console.WriteLine("\n\nAtenção ao formato do número");

            }



            catch (Exception erro)
            {
                Console.WriteLine("Ocurreu um erro");
                //throw;
                //Console.WriteLine(erro.Message);

            }

          



                Console.ReadKey();
        }
    }
}
