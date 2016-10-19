using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersBetween10and100
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumbersBetween10and100();
        }

        static void PrimeNumbersBetween10and100()
        {

            bool IsPrime = false;

            for(var i = 10; i < 101; i++)
            {
                for(var j = 2; j < i; j++)
                {
                    if(i%j == 0)
                    {
                        IsPrime = false;
                        break;
                    } else
                    {
                        IsPrime = true;
                        break;
                        
                    }
                }
                if(IsPrime)
                {
                    Console.WriteLine(i);
                }
            }

            //The code below is to first find out if a number is a prime number or not
            //Console.WriteLine("Please enter a number that you want to check is a prime or not.");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool prime = false;

            //for(var i = 2; i <= number; i++)
            //{
            //    if(number%i == 0)
            //    {
            //        break;
            //    } else
            //    {
            //        prime = true;
            //    }
            //}

            //if(prime == true)
            //{ 
            //    Console.WriteLine("{0} is a prime number.", number);
            //} else

            //{
            //    Console.WriteLine("{0} is not a prime number.", number);
            //}
        }

    }
}
