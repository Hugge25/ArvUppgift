namespace ArvUppgift
{
    public class Rectangle: Shape
    {
        public Rectangle(int x, int y) : base(x, y){
            
        }
        public int Area()
        {
           int area = width*height;
           return area;
        }
        public int Circumferance()
        {
            int circ = (width*2) + (height*2);
            return circ;
        }
    }
}