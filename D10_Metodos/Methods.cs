using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10_Metodos
{
    class Methods
    {
        public string Mensagem { get; set; }
        public int Valor1 { get; set; }
        public int Valor2 { get; set; }
        public int Resultado { get; set; }


        public void VoidMethod()
        {

            Mensagem = "Método Void: não devolve valor";
            Console.WriteLine(Mensagem);

        }

        public string NoVoidMethod()
        {

            Mensagem = "Método Void: não devolve valor";
            return Mensagem;
        }

        public void Calcular01()
        {
            Valor1 = 10;
            Valor2 = 20;
            Resultado = Valor1 + Valor2;
            Console.WriteLine(Resultado);
        }

       


        public int Calcurar02()
        {
            Valor1 = 10;
            Valor2 = 20;
            Resultado = Valor1 + Valor2;
            return Resultado;
        }
    }
}
