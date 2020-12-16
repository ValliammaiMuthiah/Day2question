using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max=0, min=0,i=0,flag=0;
            Console.WriteLine("Enter The Limits");
            max=Convert.ToInt32(Console.ReadLine( ));
            min= Convert.ToInt32(Console.ReadLine( ));
            while (min <= max)
            {
                Console.WriteLine("Enter The Limits");
                for (i = 2; i < min / 2; i++)
                {
                    if (min % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 1)
                {
                    Console.WriteLine(min);
                    flag = 0;
                }
                min++;
            }
            }
        }
    }

