using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraxyex5
{
    class Program
    {
        static void Main(string[] args)
        {


             Console.WriteLine(" ********** Even Numbers **********");

            Console.Write("Enter the size of the Array: ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];

            for (int i = 0; i < numbers.Length; i++)

            {
                Console.Write("Enter a number for index {0}: ", i);
                   numbers[i] = int.Parse(Console.ReadLine());            
           
            }

            Console.WriteLine("\n**************\n");

            for(int i = 0; i < numbers.Length; i++)

            {

                Console.WriteLine(numbers[i]);
            }


            Console.ReadLine();
        
        
        }


    }
}
