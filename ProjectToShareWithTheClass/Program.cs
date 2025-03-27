// Gabe Galiatsatos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectToShareWithTheClass
{
    /// <summary>
    /// Model an Avocado on the shelf at Kroger
    /// </summary>
    internal class Avocado
    {
        static void Main(string[] args)
        {
            Avocado myAvocado = new Avocado(); // Declare and instantiate
            myAvocado.Price = 1.69;  // Invoke the setter
            Console.WriteLine("Price of my Avocado is " + myAvocado.Price); // getter
            myAvocado.Color = "red";
            Console.WriteLine("My Avocado color is " + myAvocado.Color);
        }
    }
}
