using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please write the number of dices: ");

            int numdice = Convert.ToInt32(Console.ReadLine());
            int sumdice = 0;
            Random rnd = new Random();

            for(int i=0; i < numdice; i++)
            {                
                sumdice += rnd.Next(1,6);
            }

            Console.WriteLine("The sum number of the dices is: " + sumdice);
            
 
            
        }
    }
}
