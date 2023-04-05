// a) Method Task:
//      Min methodu yaradılır. 
//      Daxil olunan arrayın ən kiçik elementini tapır.
using System.Text;
using System.Threading.Tasks;

namespace AB_103TAsk2_a_
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int a =  Max(1,2,34,4,5,6);
            Console.WriteLine("Max Value   " +a);
           

        }
        static int Max(params int[] ints)
        {
            int[] nums = ints;
            int maxvalue = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > maxvalue)
                    maxvalue = nums[i];
          
            } return maxvalue;
        }

           
        

    }
}
// b) Overload Tasks :
//  Area deyə Method(lar) yaradılır.
// 1. Çevrənin sahəsi - S = p*r² (p=3)
// 2. Düzbucaqlının sahəsi - S = a*b
// 3. Düzbucaqlı paralelpipedin tam səthinin sahəsi - S=2(a*b+a*c+b*c)
// 4. Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S=p*r; p=(a+b+c)/2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB_103TAsk2_a_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float circle = field(3, 2);
            int duzbucaqli = field(4, 5);
            int parlepiped = field(4, 5 ,6);
            double angle = field(3,2,4,5, 6);
            Console.WriteLine(circle);
            Console.WriteLine(duzbucaqli);
            Console.WriteLine(parlepiped);
            Console.WriteLine(angle);
        }
        static float field(float p ,float r)
        {
            return p * (r*2);
        }
        static int field(int a, int b )
        {
            return a * b;
        }
        static int field(int a, int b ,int c)
        {
            return (int)2*(a*b+a*c+b*c);
        }
        static double field(double p, double r,double a, double b , double c)
        {
            p =(a+b+c)/2;
            return p*r;
        }

    }
}
