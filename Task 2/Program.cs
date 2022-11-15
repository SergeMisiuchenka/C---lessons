using System;


//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Требуется: Создать класс с именем Rectangle.  
//В теле класса создать два поля, описывающие длины сторон double side1, side2.   
//Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля side1 и side2 инициализируются значениями аргументов.  
//Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - double PerimeterCalculator().  
//Создать два свойства double Area и double Perimeter с одним методом доступа get. 
//Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь. 

namespace Task_2
{
    class Rectangle
    {
        private double side1, side2;
        
        public double Side1
        {
            get 
            { 
                return side1;
            }
        }
        public double Side2
        {
            get 
            { 
                return side2; 
            }
        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double Area
        {
            get
            {
                return side1 * side2;
            }
        }

        public double Perimeter
        {
            get
            {
                return (side1 + side2) * 2;
            }
        }
    }
    
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первую сторону прямоугольника: ");
            string a = Console.ReadLine();
            double side1 = double.Parse(a);

            Console.WriteLine("Введите вторую сторону прямоугольника: ");
            string b = Console.ReadLine();
            double side2 = double.Parse(b);

            Rectangle rectangle = new Rectangle(side1, side2);

            double perimeter = rectangle.Perimeter;
            double area = rectangle.Area;

            Console.WriteLine("Площадь равна = " + area);
            Console.WriteLine("Периметр равен = " + perimeter);






        }
    }
    
}
