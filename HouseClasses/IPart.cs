using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseClasses
{
    public interface IPart
    {
        bool GetIsRightBuild();
        void Build();
    }
}
