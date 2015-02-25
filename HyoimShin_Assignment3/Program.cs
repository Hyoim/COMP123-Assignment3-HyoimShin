/***********************************************************
 * Hyoim Shin (300802252)
 * February 25, 2015
 * Assignment3 : Implement Abstract Planets
 * Revision History : 
 * - Created giantPlanet, terrestrialPlanet Object
 * - Added waitForAnyKey() method
 * ********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyoimShin_Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 139822, 317.8, "Gas");
            Console.WriteLine(giantPlanet.ToString());

            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Venus", 12104, 0.815, true);
            Console.WriteLine(terrestrialPlanet.ToString());

            waitForAnyKey();
        }

        private static void waitForAnyKey()
        {
            Console.WriteLine("++++++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
