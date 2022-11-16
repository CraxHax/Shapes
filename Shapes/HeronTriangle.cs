using Shapes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class HeronTriangle : IBaseTriangle
    {
        protected readonly double ab;
        protected readonly double bc;
        protected readonly double ac;
        protected readonly double p; //halfPerimeter
        protected readonly double area;
        protected readonly bool isRight;

        public HeronTriangle(double ab, double bc, double ac)
        {
            List<double> sorted = new List<double>()
            {
                ab, bc, ac
            };

            sorted.Sort();
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;
            p = (ab + bc + ac) / 2;
            isRight = Helpers.AreEqual(sorted[0] * sorted[0] + sorted[1] * sorted[1], sorted[2] * sorted[2]);
            area = isRight ? sorted[0] * sorted[1] : Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
        }

        public double AB => ab;

        public double BC => bc;

        public double AC => ac;

        public virtual double GetArea()
        {
            return area;
        }

        public virtual bool IsRight()
        {
            return isRight;
        }

    }
}
