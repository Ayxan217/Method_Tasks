namespace Method_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("area of rectangle: "+Area(5, 6));
            Console.WriteLine("Area of paralelopiped: " + Area(5, 6,2));
            Console.WriteLine("Area of circle: " + Area(5));
            Console.WriteLine("Area of circle in triangle: " + Area(4,5, 6, 2));


        }
        public static int Area(int a, int b)
        {
            int s = a * b;
            return s;
        }
        public static int Area(int a, int b,int c)
        {
            int s = 2*(a*b+a*c+b*c);
            return s;
        }
        public static int Area(int r)
        {
            int pi = 3;
            int s =pi*(r*r) ;
            return s;
        }
        public static int Area(int r, int a, int b, int c)
        {
            int p = (a+b+c)/2;
            int s = p*r;
            return s;
        }
    }
}
