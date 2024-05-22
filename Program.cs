using System;
using System.ComponentModel;
using System.Data;

namespace MethodTask
{
    internal class Program
    {
        static void Main(string[] args)
        {



        }

        static void Ьultiplication(int x, int y)
        {
            Console.WriteLine(x*y);
        }

        static void Degree(int x)
        {
            Console.WriteLine(x*x);
        }


        static void Summer(int[] arr)
        {
            var sum = 0;

            foreach (var item in arr)
            {
                  sum+= item;   
            }

            Console.WriteLine(sum);
        }



        static string SayHello(string Name, string Surname)
        {
            return $"Xos Gelmisen{Name} {Surname}";
        }



        static string Reverse(string str)
        {
            var newStr = " ";


            for (int i = str.Length; i < str.Length; i--)
            {
                newStr += str[i];
            }


            return newStr ;
        }



        static void Divide(int x)
        {
            if(x%7==0)
            {
                Console.WriteLine("7-ye tam bolunur");
            }
            else
                Math.Round(Convert.ToDecimal(x));
        }


        static void FindSP(int x,int y,int z,int d)
        {
            Console.WriteLine(x+y+z+d);
        }



        static void FindSP(int x, int y, int z)
        {
            Console.WriteLine(x + y + z);
        }




        static int SpaceCount(string str)
        {
            var count = 0;


            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==' ')
                {
                    count++;    
                }
            }


            return count;
        }


    }
}
