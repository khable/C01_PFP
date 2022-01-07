using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12_Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList : inteiros

         

            //1 Instanciar
            ArrayList listaNumeros = new ArrayList();

            //2 Adicionar Valores com o método Add
            listaNumeros.Add(100);
            listaNumeros.Add(-30);
            listaNumeros.Add(499);
            listaNumeros.Add(41);

            //3 Adicionar com For
            for (int i = 0; i <11 ; i++)
            {
                listaNumeros.Add(i);
            }

            //500 a 520 de 2 em 2
            for (int i = 500; i < 521; i = i + 2)
            {
                listaNumeros.Add(i);
            }



            //4 Listar com Foreach

            foreach (int item in listaNumeros)
            {

                Console.WriteLine(item);

            }

            
            #endregion

            Console.ReadKey();
            Console.Clear();

            #region ArrayList : strings

            //1 Instaciar e adicionar valores
            ArrayList listaStrings = new ArrayList()
            {

                "a" ,
                "b" ,
                "c" ,
                "d"

            };

            //2 Adicionar valores com metodos add
            listaStrings.Add("C#");
            listaStrings.Add("Microsoft");
            
            //3 Adicionares valores pela consola
            Console.WriteLine("Nova string : ");
            listaStrings.Add(Console.ReadLine());


            //4. Listar

            foreach (string item in listaStrings)
            {
                Console.WriteLine(item);

            }



            #endregion
           
            Console.ReadKey();
            Console.Clear();

            #region ArrayList : pessoas


            ArrayList listaPessoas = new ArrayList();
           
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            pessoa1.Name = "Carlos";
            pessoa1.Location = "Melres";

            pessoa2.Name = "Joel";
            pessoa2.Location = "Zebreiros";

            listaPessoas.Add(pessoa1);
            listaPessoas.Add(pessoa2);


            foreach (Pessoa item in listaPessoas)
            {
                Console.WriteLine($"{item.Name}\t mora em : {item.Location}");
            }


            #endregion

            Console.ReadKey();
            Console.Clear();

            #region funcionarios

            ArrayList listafuncionarios = new ArrayList();

            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            funcionario1.Name = "Pedro";
            funcionario1.Location = "Espinho";
            funcionario1.Departamento = "Recursos Humanos";

            funcionario2.Name = "Luis";
            funcionario2.Location = "Melres";
            funcionario2.Departamento = "Informatica";

            listafuncionarios.Add(funcionario1);
            listafuncionarios.Add(funcionario2);

            foreach (Funcionario item in listafuncionarios)
            {
                Console.WriteLine($"{item.Name}\t mora em : {item.Location}\t e o departamento é : {item.Departamento}");
            }



            #endregion



        }
    }
}
