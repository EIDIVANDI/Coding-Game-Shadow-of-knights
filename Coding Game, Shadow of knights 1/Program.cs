using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Shadow
{
    // the last test did not pass , and i modified the code 
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // width of the building.
        int H = int.Parse(inputs[1]); // height of the building.
        int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
        inputs = Console.ReadLine().Split(' ');
        int X0 = int.Parse(inputs[0]);
        int Y0 = int.Parse(inputs[1]);
        int XN = 0, YN = 0;
        int minY = 0, minX = 0, maxY = H, maxX = W, lastX = X0, lastY = Y0;
        // game loop
        while (true)
        {
            string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)

            if (bombDir.Length != 0)
            {
                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");
                foreach (var a in bombDir.ToCharArray())
                {
                    if (a == 'U')
                    {

                        YN = (minY + Y0) / 2;
                        minY = minY > 0 ? minY : 0;
                        maxY = Y0;

                    }
                    else if (a == 'D')
                    {
                        YN = (maxY + Y0) / 2;
                        minY = Y0;
                        maxY = H;
                    }
                    else if (a == 'L')
                    {
                        XN = (minX + X0) / 2;
                        minX = minX > 0 ? minX : 0;
                        maxX = X0;
                    }
                    else if (a == 'R')
                    {
                        XN = (maxX + X0) / 2;
                        minX = X0;
                        maxX = W;
                    }
                    else
                        break;

                }

            }
            X0 = XN;
            Y0 = YN;
            lastY = Y0;
            lastX = X0;

            // the location of the next window Batman should jump to.
            Console.WriteLine(string.Format("{0} {1}", X0, Y0));
            //Console.WriteLine("3 7");
        }
    }
}