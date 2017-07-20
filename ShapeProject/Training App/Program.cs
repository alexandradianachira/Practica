using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_App.Classes;

namespace Training_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var cube = new cube();
            var square = new square();

            cube.setL(2);
            square.setL(5);

            bool bExit = true;

            while (bExit)
            {
                var sh = new shape();

                Console.WriteLine(@"Type your choice or type '0' to exit");
                Console.WriteLine(@"Select shape to paint: 1 - square, 2 - cube");

                string line = Console.ReadLine();
                if (line == "0")
                {
                    break;
                }
                switch (line)
                {
                    case "1":
                        sh = square;
                        break;
                    case "2":
                        sh = cube;
                        break;
                    default:
                        break;
                }

                sh.theArea(sh.getL());


                
            }

        }
    }
}
