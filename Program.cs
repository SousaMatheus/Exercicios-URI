using System;

namespace Exercicios_URI 
{
    class Program
    {
        static void Main(string[] args)
        int a, b, m;
            string []vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]); 

            if ( a % b == 0 || b % a == 0){
                Console.Writeline("Sao Multiplos");
                
            }
            else {
                Console.Writeline("Nao sao Multiplos")
            }
        }
        console.ReadLine();
    }
}
