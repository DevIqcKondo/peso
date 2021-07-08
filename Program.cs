using System;

namespace peso
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexo;
            double alt=0;
            double result=0;

            Console.WriteLine("+--------------+");
            Console.WriteLine("|Seu peso ideal|");
            Console.WriteLine("+--------------+");

            Console.Write("Digite sua altura em metros: ");
            alt = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe seu sexo utilizando (M) para masculino ou (F) para feminino: ");
            sexo=Convert.ToChar(Console.ReadLine());

            if(sexo == 'm'){
                result = (alt * 72.7) -58.0;
                Console.WriteLine($"Seu peso ideal é {result}kg");
            }
            if(sexo == 'f'){
                  result = (alt * 62.1)- 44.7;
                  Console.WriteLine($"Seu peso ideal é {result}kg");
            }

        }
    }
}
