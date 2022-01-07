using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Carro
{
    class Carro
    {

        #region Inumerations

        public enum EnumMarca
        {
            Ford ,
            Kia ,
            Toyota

        }

        public enum EnumModelo
        {
            Fiesta,
            Focus ,
            k1 ,
            k2 ,
            k3 ,
            Ailux , 
            Corolla 

        }

        public enum EnumCor
        {
            Preto ,
            Branco ,
            Cinzento , 
            Azul ,
            Vermelho ,
            Verde

        }

        #endregion


        #region Properties

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Matricula { get; set; }
        public int Cilindrada { get; set; }
        public int Velocidade { get; set; }
       


        #endregion

        #region Constructors

        public Carro()
        {
            Marca = string.Empty;
            Modelo = string.Empty;
            Cor = string.Empty;
            Matricula = string.Empty;
            Cilindrada = 0;
            Velocidade = 0;
        }

        public Carro(string marca , string modelo , string cor , string matricula , int cilindrada , int velocidade)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Matricula = matricula;
            Cilindrada = cilindrada;
            Velocidade = velocidade;
        }


        public Carro(string matricula, int cilindrada, int velocidade)
        {
            Marca = string.Empty;
            Modelo = string.Empty;
            Cor = string.Empty;
            Matricula = matricula;
            Cilindrada = cilindrada;
            Velocidade = velocidade;
        }




        #endregion

        #region Methods

        public void Criar()
        {
            Console.Write("Marca : ");
            Marca = Console.ReadLine();

            Console.Write("Modelo : ");
            Modelo = Console.ReadLine();

            Console.Write("Cor : ");
            Cor = Console.ReadLine();

            Console.Write("Matricula : ");
            Matricula = Console.ReadLine();

            Console.Write("Cilindrada : ");
            Cilindrada = Convert.ToInt32(Console.ReadLine());

            Console.Write("Velocidade : ");
            Velocidade = Convert.ToInt32(Console.ReadLine());
        }

        public void Criar3Propriedades()
        {
            Console.Write("Marca : ");
            Marca = Console.ReadLine();

            Console.Write("Modelo : ");
            Modelo = Console.ReadLine();

            Console.Write("Cor : ");
            Cor = Console.ReadLine();

        }

        public void ListarCarro(string titulo)
        {
            Console.Clear();

            Console.WriteLine($"--------------------------------\nCarro {titulo}  \n----------------------------\n" );

            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Matricula: {Matricula}");
            Console.WriteLine($"Cilindrada: {Cilindrada}");
            Console.WriteLine($"Velocidade: {Velocidade}");

            Console.ReadKey();
        }

        public void Parar()
        {
            Velocidade = 0;
        }
       
        public void Acelerar (int valor)
        {
            Velocidade = Velocidade + valor;
            
        }

        public void Desacelerar(int valor)
        {
            Velocidade = Velocidade - valor;

        }







        #endregion

        #region Destrutor
        ~Carro()
        {
            //GB - Garbage collector
            //Para ver a mensagem executar com ctrlF5
            Console.WriteLine("O carro vai pra sucata");
        }
        #endregion

        #region Destructor

        #endregion

    }
}
