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
            int area = (width*height);
            return area;
        }
        public int Circumferance()
        {
            int c = (int)Math.Sqrt(width^2 + height^2);
            int circ = width+height+c;
            return circ;
        }
    }
}