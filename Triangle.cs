using System.Security.Cryptography.X509Certificates;

namespace ArvUppgift
{
    public class Triangle: Shape
    {
        public Triangle(int x, int y) : base(x, y)
        {

        }
        public int Area()
        {
            int area = (width*height)/2;
            return area;
        }
        public int Circumferance()
        {
            int c = (int)Math.Sqrt(Math.Pow(width,2) + Math.Pow(height, 2));
            int circ = width+height+c;
            return circ;
        }
    }
}