using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Base
{
    public static class Constants
    {
        public static readonly double DefaultEpsilon = 0.00000095367431640625d;// 2 ^ -20

        public static double Epsilon { get; private set; } = DefaultEpsilon;
        public static double PI { get; private set; } = Math.PI;

        public static void SetEpsilon(double epsilon)
        {
            if (epsilon <= 0 || epsilon > 0.01)
            {
                throw new ArgumentException("Значение epsilon должно быть в (0;0.01]");
            }
            Epsilon = epsilon;
        }

        public static void SetPI(double pi)
        {
            if (pi < 3.14 || pi > 3.15)
            {
                throw new ArgumentException("Значение pi должно быть в [3.14;3.15]");
            }

            PI = pi;
        }
    }
}
