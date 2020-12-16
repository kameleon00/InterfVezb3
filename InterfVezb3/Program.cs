using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfVezb3
{
    class Program
    {
        static void Main()
        {
            //1. Deklaracija instance klase Box: box1
            Box box1 = new Box(30, 20);

            //2.Deklaracija instance interfejsa IDimensions:
            IDimensions dimensions = (IDimensions)box1;

            //6. Prikaz dimenzija kutije preko instance interfejsa:
            Console.WriteLine("Lenght {0} ", dimensions.getLength());
            Console.WriteLine("Width {0} ", dimensions.getWidth());

            Console.ReadKey();
        }
    }
}
