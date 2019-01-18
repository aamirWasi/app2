using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your testcase :");
            int T = Convert.ToInt32(Console.ReadLine());
            while (T!=0)
            {
                Console.Write("Enter velocity & Time");
                double velo = Convert.ToDouble(Console.ReadLine());
                double Time = Convert.ToDouble(Console.ReadLine());

                double deacltor = -(velo / Time);
                Console.WriteLine("Result is :{0}", deacltor);
            }
        }
    }
}
