using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Base
{
    public interface IBaseTriangle: IShape
    {
        public double AB { get; }
        public double BC { get; }
        public double AC { get; }
        public bool IsRight();
    }
}
