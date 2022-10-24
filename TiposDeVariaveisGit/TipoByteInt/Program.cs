using System;

namespace TipoByteInt
{
    class Program
    {
        static void Main(string[] args)
        {
            byte v1 = 44;
            Console.WriteLine("O valor de v1 é {0}",v1);
            Console.WriteLine("O tipo de v1 é {0}", v1.GetType());

            Console.WriteLine("Digite um valor na faixa de 0 a 255");

            try
            {
                byte vdigitado = Convert.ToByte(Console.Readline());
                Console.WriteLine("O valor digitado é {0}", vdigitado);
            }
            catch (OverflowException)
            {
                Console.WriteLine("O valor digitado não é byte");
            }
        }
    }
}
