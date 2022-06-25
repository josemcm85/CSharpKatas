using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCSharp
{
    public class Classmates
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            
            double PointsClass = ClassPoints.Average();
            if(PointsClass < YourPoints)
            {
                return true;
            } else
            {
                return false;
            }

            //BEST PRACTICE
            //return YourPoints > ClassPoints.Average();

        }

    }
}
