using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfVezb3
{
    class Box : IDimensions
    {
        float lengthInches;
        float widthInches;

        public Box (float lenght, float width)
        {
            lengthInches = lenght;
            widthInches = width;
        }

        //1. Eksplicitna implementacija metode getLength:
        float IDimensions.getLength()
        {
            return lengthInches;
        }
        float IDimensions.getWidth()
        {
            return widthInches;
        }
    }
}
