using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallFunciones
{
    class Program
    {
        static void Main(string[] args)
        {
            BibliotecadeFunciones.Operaciones ob1 = new BibliotecadeFunciones.Operaciones();
            double x1 = ob1.suma(289, 89, 100, 00);
            double fac = ob1.factorial(5);
            Console.WriteLine($"La suma es {5}");
            Console.WriteLine($"El factorial de 5 es {fac}");
            Console.WriteLine("Presiona center para finalizar...");
            Console.ReadKey();
        }
       
    }
}
