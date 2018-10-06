using System;

namespace homework3
{
   
    interface Area
    {
        void areaCalculation();
    }


    class Triangle : Area
    {
        double side1, side2, side3;
        public Triangle(double a, double b, double c)
        {
            side1 = a;
            side2 = b;
            side3 = c;
            if (a + b < c || a + c < b || b + c < a || a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("创建三角形失败");
            }
            else
            {
                Console.WriteLine("创建三角形");
            }
        }
        public void areaCalculation()
        {
            double p = (side1 + side2 + side3) / 2;
            double n = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            if ((side1 + side2 > side3 || side2 + side3 > side1 || side1 + side3 > side2) && side1 > 0 && side2 > 0 && side3 > 0)
            {
                Console.WriteLine("三角形面积是:" + n);
            }
        }
    }
    class Circle : Area
    {
        double radius;
        public Circle (double a)
        {
            radius = a;
            if (a > 0)
                Console.WriteLine("创建圆形");
            else
                Console.WriteLine("创建圆形失败");
        }
        public void areaCalculation()
        {
            if(radius>0)
            Console.WriteLine("圆形面积是:" + (radius * radius * System.Math.PI));
        }
    }

    class Square : Area
    {
        double side;
        public Square(double a)
        {
            side = a;
            if (a > 0)
                Console.WriteLine("创建正方形");
            else
                Console.WriteLine("创建正方形失败");
        }
        public void areaCalculation()
        {
            if(side>0)
            Console.WriteLine("正方形面积是:" + (side * side));
        }
    }

    class Rectangle : Area
    {
        double length,width;
        public Rectangle(double a,double b)
        {
            length = a;
            width = b;
            if (a > 0&&b>0)
                Console.WriteLine("创建长方形");
            else
                Console.WriteLine("创建长方形失败");
        }
        public void areaCalculation()
        {
            if (length > 0||width>0)
                Console.WriteLine("正方形面积是:" + (length * width));
        }
    }
    class Factory
    {
        //静态工厂方法  
        public static void getShape()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n.Equals(0))
            {
                try {
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double num3 = Convert.ToDouble(Console.ReadLine());
                    Triangle triangle = new Triangle(num1, num2, num3);
                    triangle.areaCalculation();
                }catch(Exception e)
                {
                    Console.WriteLine("ERROR"+e.Message);
                }
                }
            else if (n.Equals(1))
            {
                try
                {
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Circle circle = new Circle(num1);
                    circle.areaCalculation();
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR" + e.Message);
                }
            }
            else if (n.Equals(2))
            {
                try
                {
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Square square = new Square(num1);
                    square.areaCalculation();
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR" + e.Message);
                }
            }
            else
            {
                try
                {
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(num1, num2);
                    rectangle.areaCalculation();
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR" + e.Message);
                }
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Factory.getShape();//分别输入n=0,1,2,3时的情况
        }
    }
}
