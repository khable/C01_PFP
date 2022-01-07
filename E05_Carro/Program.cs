using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Carro
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Carro carro1 = new Carro();
                carro1.Criar();
                carro1.ListarCarro("1");


                Carro carro2 = new Carro("Ford", "Fiesta", "Cinzento ", "10-GH-39", 2000, 80);
                carro2.ListarCarro("2");


                Carro carro3 = new Carro("56-GL-23", 1800, 90);
                carro3.Criar3Propriedades();
                carro3.ListarCarro("3");

            }
            catch (Exception ex)
            {

                Console.WriteLine("\n\nErro !");
                Console.WriteLine($"Detalhe do Erro : {ex.Message} ");

                Console.ReadKey();
            }

            Console.ReadKey();
            
        }
    }
}
