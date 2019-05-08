using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_design_pattern
{
    public class Triangle : GeometricShape
    {
        private int a, b, c;

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }

        public double area()
        {
            /*
 Step 1: Calculate "s" (half of the triangles perimeter):

 s =  a+b+c2 
 Step 2: Then calculate the Area:

 herons formula A = sqrt( s(s-a)(s-b)(s-c) )

             */
            //return 0;

            double s = A + B + 2 * C;
            double cikti = Math.Sqrt(s * (s - A) * (s - B) * (s - C));

            return cikti;
        }

        public string drawShape()
        {
            //Console.WriteLine("Drawing Triangle with area: " + area());
            return "Drawing Triangle with area: " + area();
        }


    }
}
