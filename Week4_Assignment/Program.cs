using System;

namespace Week4_Assignment
{
    class Program
    {
        public static Random random;
        public static Rectangle rect ;
        static void Main(string[] args)
        {
            random = new Random();
            rect = new Rectangle();

            int l = 0;
            int w = 0;
            
            MakeRectangle(out l, out w);

            rect.length = l;
            rect.width = w;

            int area = Utility.areaRectangle(rect.length, rect.width);
            int perimeter = Utility.perimeterRectangle(rect.length, rect.width);
            
            Console.WriteLine("The length is: " + l);
            Console.WriteLine("The width is: " + w);
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
        }

        public class Rectangle
        {
            public int width;
            public int length;
        }


         class Utility
            {
            public static int areaRectangle(int l, int w)
            {
                int area = l * w;
                return area;
            }

             public static int perimeterRectangle(int l, int w)
            {
                int perimeter = 2 * (l + w);
                return perimeter;
            }
        }

        static void MakeRectangle(out int l, out int w)
        {
            l = random.Next(0, 100);
            w = random.Next(0, 100);
        }
    
        static int Add(int l, int w)
        {
            return l + w;
        }
    }

}
