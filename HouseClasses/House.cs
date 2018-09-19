using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseClasses
{
    public class House : IPart
    {
        public const int NUMBER_OF_WALLS = 4;
        public const int NUMBER_OF_OBJ = 11;
        public bool IsRightBuild { get; set; }
        public string house { get; set; }
        public Basement basement { get; set; }
        public Door door { get; set; }
        public Roof roof { get; set; }
        public Wall[] wall { get; set; }
        public Window[] window { get; set; }

        public House()
        {
            wall = new Wall[NUMBER_OF_WALLS];
            window = new Window[NUMBER_OF_WALLS];
        }

        public void Build()
        {
            IsRightBuild = true;
        }

        public bool GetIsRightBuild()
        {
            return IsRightBuild;
        }

        public int GetNumberWall()
        {
            return NUMBER_OF_WALLS;
        }

        public int GetNumberObject()
        {
            return numberOfObj;
        }
    }
}
