using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioDadosPessoais
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario funcionario1 = new Funcionario();

            funcionario1.LerPrimeiroNome();
            funcionario1.LerNomeDoMeio();
            funcionario1.LerUltimoNome();
            funcionario1.EscreverMensagem();

            Console.ReadKey();

        }
    }
}
