using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StalconLib
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
                if (Distance(places[i], places[i + 1]) > path)
                    path = Distance(places[i], places[i + 1]);
            return path;
        }
        public double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.GetX() - p2.GetX(), 2) + Math.Pow(p1.GetY() - p2.GetY(), 2));
        }
    }
}
