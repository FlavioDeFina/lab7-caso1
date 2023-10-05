using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_caso1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el vamor de n: ");
            int n = int.Parse(Console.ReadLine());
            float resultado = 0f;
            float total = 0f;
            for (int i = 1; i <= n; i++) 
            {
                resultado = (16f - i) / (3f * i);
                Console.WriteLine("Resultado : " + resultado);
                total = total + resultado;
            }
            Console.WriteLine("El total es : "+total);
            Console.ReadKey();
        }
    }
}
