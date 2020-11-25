using System;

namespace Ex5_ListaFixacao
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int [10];
            int resultado = 0;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please type a number from 1 to 10 to know its multiplication table:\n ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

                
                for (int i = 0; i <= 10; i++)
                
                {
                    
                    resultado = i * num;
                    Console.WriteLine($"{i} x {num} = {resultado}"); 


                }
            
        
        }          
    }
}
    
