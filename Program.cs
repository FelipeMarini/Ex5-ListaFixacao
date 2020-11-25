using System;

namespace Ex5_ListaFixacao
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 0;
            int resultado = 0;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Here are the multiplication tables of numbers 1 until 10:\n ");
            Console.ResetColor();
            Console.WriteLine();

                
                for (int k = 1; k <= 10; k++) {
                    
                        num = k;

                        Console.WriteLine("------------------------------------------");                    
                    
                    
                    for (int i = 0; i <= 10; i++)
                    {

                        Console.WriteLine();
                        
                        resultado = i * num;

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine($"{i} x {num} = {resultado}"); 

                        Console.ResetColor();

                    }
                
                }
        }          
    }
}
                    
    
            
