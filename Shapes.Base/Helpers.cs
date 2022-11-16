using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Base
{
    public static class Helpers
    {
        public static bool AreEqual(double a, double b)
        {
            return AreEqual(a, b, Constants.Epsilon);
        }

        public static bool AreEqual(double a, double b, double epsilon)
        {
            return Math.Abs(a - b) < epsilon;
        }
    }
}
