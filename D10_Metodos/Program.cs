using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10_Metodos
{
    class Program
    {
        static void Main (string[] args)
        {
            Methods method1 = new Methods();

            //method1.VoidMethod();
            //method1.NoVoidMethod();

            method1.Calcular01();

            Console.WriteLine(method1.Calcurar02());

            Console.ReadKey();

        }
    }
}
