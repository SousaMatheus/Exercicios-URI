using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string [] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
<<<<<<< HEAD
            b = int.Parse(vet[1]);
            if (a % b == 0 || b % a == 0){
                Console.WriteLine("Sao Multiplos");
            } else {
                Console.WriteLine("Nao sao Multiplos");
            }
            Console.ReadLine();
=======
            b = int.Parse(vet[1]); 

            if ( a % b == 0 || b % a == 0){
                Console.Writeline("Sao Multiplos");
                
            }
            else {
                Console.Writeline("Nao sao Multiplos")
            }
        }
        console.ReadLine();
>>>>>>> c9a50b7bfef8310ebf2b41b14c66edc92b442b47
    }
}
}