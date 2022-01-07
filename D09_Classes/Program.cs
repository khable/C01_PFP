using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instanciar um objecto da classe funcionario

            Funcionario funcionario1 = new Funcionario();

            //Executar os metodos

            funcionario1.LerNome();
            funcionario1.LerEmail();
            funcionario1.EscreverMensagem();

            // Pausar a consola

            Console.ReadKey();




        }
    }

    }

