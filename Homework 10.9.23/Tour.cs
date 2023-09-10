using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivgi
{
    class Tour
    {
        private string name;
        private Point[] places;
        private int index;
        public Tour(string name)
        {
            this.name = name;
            places = new Point[20];
            index = 0;
        }
        public bool AddPoint(Point p)
        {
            if (index < 20)
            {
                places[index] = p;
                return true;
            }
            return false;
        }
        public Point HeighestPoint()
        {
            int maxIndex = 0;
            int max = places[0].GetY();
            for (int i = 0; i < places.Length; i++)
                if (places[i].GetY() > max)
                {
                    max = places[i].GetY();
                    maxIndex = i;
                }
            return places[maxIndex];
        }
        public double LongestPath()
        {
            double path = 0;
            for (int i = 0; i < places.Length - 1; i++)
                if (Utils.Distance(places[i], places[i + 1]) > path)
                    path = Utils.Distance(places[i], places[i + 1]);
            return path;
        }
    }
}
