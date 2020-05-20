using System;

namespace soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Digite um número...:");
        

          int X = Int32.Parse (Console.ReadLine ()); 



          Console.WriteLine("Digite outro número...:");

          int Y = Int32.Parse (Console.ReadLine ());



          int soma = X + Y; 

          Console.WriteLine ("Resultado da soma:" + soma);

          

          Console.ReadKey ();
        
        
        
        }
    }
}
