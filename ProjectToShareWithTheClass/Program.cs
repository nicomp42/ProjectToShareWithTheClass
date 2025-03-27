using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectToShareWithTheClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avocado myAvocado = new Avocado(); // Declare and instantiate
            myAvocado.Price = 1.69;  // Invoke the setter
            Console.WriteLine("Price of my Avocado is " + myAvocado.Price); // getter

            myAvocado.Color = "brown"; //invoke
            Console.WriteLine("The color of my Avocado is " + myAvocado.Color);
                               
            Console.ReadKey();
        }
    }
}
