using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Week1.rectangle_area
{
    public class Solution
    {
        public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
        {
            int areaOfA = (ay2 - ay1) * (ax2 - ax1);
            int areaOfB = (by2 - by1) * (bx2 - bx1);

            //  x overlap
            int left = Math.Max(ax1, bx1);
            int right = Math.Min(ax2, bx2);
            int xOverlap = right - left;

            //  y overlap
            int top = Math.Min(ay2, by2);
            int bottom = Math.Max(ay1, by1);
            int yOverlap = top - bottom;

            int areaOfOverlap = 0;

            if (xOverlap > 0 && yOverlap > 0)
            {
                areaOfOverlap = xOverlap * yOverlap;
            }


            int totalArea = areaOfA + areaOfB - areaOfOverlap;

            return totalArea;
        }
    }
}
