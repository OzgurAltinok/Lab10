using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_design_pattern
{
    class Triangle : GeometricShape
    {

      
        public double area()
        {

            /*
 Step 1: Calculate "s" (half of the triangles perimeter):

 s =  a+b+c2 
 Step 2: Then calculate the Area:

 herons formula A = sqrt( s(s-a)(s-b)(s-c) )

             */
            return 0;
        }

        public void drawShape()
        {
           Console.WriteLine("Drawing Triangle with area: " + area() );
        }


    }
}
