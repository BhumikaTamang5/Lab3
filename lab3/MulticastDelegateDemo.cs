using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhumika.Unit_3
{
    public delegate void ADelegate(int a, int b);
    internal class MulticastDelegateDemo
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine("Sum is {0}", a + b);
        }
        public void Diff(int a, int b)
        {
            Console.WriteLine("Difference is {0}", a - b);
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine("Product is {0}", a * b);
        }
        public void Div(int a, int b)
        {
            Console.WriteLine("Division is {0}", a / b);
        }
       /* static void Main(string[] args)
        {
            MulticastDelegateDemo demo = new MulticastDelegateDemo();
            ADelegate ad = new ADelegate(demo.Sum);
            ad.Invoke(988, 66);
            ad += demo.Diff;
            ad += demo.Mul;
            ad += demo.Div;
            ad.Invoke(569, 45);
            ad -= demo.Diff;
            ad.Invoke(200, 3000);

            Console.ReadKey();
        }*/
       
    }
}
