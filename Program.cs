using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_LacoDeRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto - Laço de Repetição For: \r\n");

            Console.WriteLine("____________________________________________________________________ \r\n");
            Console.WriteLine("Contador de 0 a 10: \r\n");

            for (int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine(contador);
            }
            Console.ReadLine();
        }
    }
}
