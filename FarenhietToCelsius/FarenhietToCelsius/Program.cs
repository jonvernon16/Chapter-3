using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarenhietToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempInF;
            int tempInC;

            Console.Write("Please Enter the tempature in Farenhiet >>> ");
            tempInF = Convert.ToInt32(Console.ReadLine());

            tempInC = (tempInF - 32) * (5 / 9);

            Console.WriteLine("The temp is {0}C ", tempInC);


        }
    }
}
