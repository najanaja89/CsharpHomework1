using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1
{
    class Program
    {
        static void Main(string[] args)
        { 

            //Вывести имя на консоль
            Console.WriteLine("Ruslan Tyo");
            Console.WriteLine();

            Console.WriteLine("Enter number one ");
            var digitTemp = Console.ReadLine();
            int numberOne = int.Parse(digitTemp);

            Console.WriteLine("Enter number two ");
            digitTemp = Console.ReadLine();
            int numberTwo = int.Parse(digitTemp);

            Console.WriteLine("Enter number Three ");
            digitTemp = Console.ReadLine();
            int numberThree = int.Parse(digitTemp);


            int sum = numberOne + numberTwo + numberThree;

            Console.WriteLine();
            Console.Write(sum);


            Console.ReadLine();
        }
    }
}
