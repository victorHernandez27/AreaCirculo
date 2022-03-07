using System;

namespace AreaCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float raio;
            

            Console.WriteLine("Digite o valor do raio:");
            raio = float.Parse(Console.ReadLine());

            if(raio <= 0)
            {
                Console.WriteLine("Não ha valor possível para calcular uma área");
            }
            else
            {                
                Console.WriteLine("A area do circulo é: {0}", (3.1415 * (raio * raio)));
            }

        }
    }
}
