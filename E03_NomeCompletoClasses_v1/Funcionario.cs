using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioDadosPessoais
{
    class Funcionario
    {
        #region Properties

        public string PrimeiroNome { get; set; }
        public string NomeDoMeio { get; set; }
        public string UltimoNome { get; set; }

        #endregion

        #region Methods
        public void LerPrimeiroNome()
        {
            Console.Write("Primeiro Nome é : ");
            PrimeiroNome =  Console.ReadLine();
        }

        public void LerNomeDoMeio()
        {
            Console.Write("Nome do Meio é : ");
            NomeDoMeio = Console.ReadLine();

        }


        public void LerUltimoNome()
        {

            Console.Write("Ultimo nome é : ");
            UltimoNome = Console.ReadLine();

        }


        public void EscreverMensagem()
        {
            Console.WriteLine($" \nO Primeiro nome do Funcionário é {PrimeiroNome.ToUpper()} o segundo nome é {NomeDoMeio.ToUpper()} e o terceiro é {UltimoNome.ToUpper()} .");
        }

        #endregion


    }
}
