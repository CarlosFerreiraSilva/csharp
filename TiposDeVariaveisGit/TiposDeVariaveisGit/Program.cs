using System;

namespace TiposDeVariaveisGit
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 5;
            int num2 = num1;
            int resultado = num1 + num2;
            num1 = 6;
            Console.WriteLine("Valor do num1 é: {0} e está na stack", num1.ToString());
            Console.WriteLine("Valor do num2 é: {0} e está na stack", num2.ToString());
          
            Console.WriteLine("Calculadora");
            Calculadora minhaCalculadora = new Calculadora();
            minhaCalculadora.somar();

            Console.WriteLine("Variaveis nullo");
            int? altura = null;

            if (altura.HasValue)
            {
                Console.WriteLine("O valor é: {0} ", altura.ToString());
            }
            else
            {
                Console.WriteLine("A altura é nullo");
            }

            Console.ReadKey();
       

        }
        
    }
}
