using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x(1000<x<9999) = ");
            int x,a,b,c,d;
            bool t = false;
            x=Convert.ToInt32(Console.ReadLine());
            a = x / 1000;
            b = (x - 1000 * a) / 100;
            c = (x - 1000 * a - 100 * b) / 10;
            d = (x - 1000 * a - 100 * b-10*c) ;
            //61
            if (d + c == a + b) t=true;
            
            Console.WriteLine(Convert.ToString(t));
            //62
            if (x < 5000) Console.WriteLine(Convert.ToDouble(x)/(Convert.ToDouble(b) + Convert.ToDouble(d)) );
            else  Console.WriteLine(Convert.ToDouble(x)/(Convert.ToDouble(a) + Convert.ToDouble(c)) );
            //63
            if (a == 1 || b == 1 || c == 1 || d == 1) Console.WriteLine("1");
            else Console.WriteLine("2");
            //64
            char y;
            if (c + d == 5) y = 's';
            else y = 'd';
            Console.WriteLine(y);
            //65
            if (d * c == 12) Console.WriteLine("y=12");
            else Console.WriteLine("y=0");
            //66
            if (a == 4 || d == 4) Console.WriteLine("Yes");
            else Console.WriteLine("No");
            //67
            if (x == Math.Pow((a + b + c + d), 2)) Console.WriteLine("Yes");
            else Console.WriteLine("No");
            //68
            if (d > c) Console.WriteLine(d * b);
            else Console.WriteLine("1");
            //69
            int y1;
            if (a+b+c+d>20) y1 = 1;
            else y1 = 0;
            Console.WriteLine(y1);
            //70
            if (a * b * c * d > 200) y1 = 0;
            else y1=1;
            Console.WriteLine(y1);


            




            Console.ReadKey();  
            
        }
    }
}
