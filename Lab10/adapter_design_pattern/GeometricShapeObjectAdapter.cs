using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_design_pattern
{
    public class GeometricShapeObjectAdapter : Shape
    {
        Triangle t;

        public GeometricShapeObjectAdapter(Triangle t)
        {
            T = t;
        }

        public Triangle T { get => t; set => t = value; }

        public void draw()
        {
            //Console.WriteLine("Drawing Triangle");
            // T.drawShape() kullanabilmek için GeometricShape interface'indeki drawShape()'i void değil
            // string döndürsün diye yazdım.

            Console.WriteLine(T.drawShape());
        }
    }
}
