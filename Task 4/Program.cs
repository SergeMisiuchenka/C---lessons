using System;

//Создать классы Point и Figure.  
//Класс Point должен содержать два целочисленных поля и одно строковое поле. 
//Создать три свойства с одним методом доступа get.  
//Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов. Класс Figure должен содержать конструкторы,
//которые принимают от 3-х до 5-ти аргументов типа Point. 
//Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника; void PerimeterCalculator(),
//который рассчитывает периметр многоугольника. 
//Написать программу, которая выводит на экран название и периметр многоугольника. 


namespace Task_4
{
    class Figure
    {
        public Figure()
        {
        }

        public Figure(Point point1, Point point2, Point point3)
        {
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
        }
    }
    class Program
    {
        public static double LenghtSide(Point pointA, Point pointB)
        {
            double lenghtSide;
            var square1 = (pointB.x - pointA.x) * (pointB.x - pointA.x);
            var square2 = (pointB.y - pointA.y) * (pointB.y - pointA.y);
            var summ = square1 + square2;
            lenghtSide = Math.Sqrt(summ);
            return lenghtSide;
        }

        public static void PerimeterCalculator(double[] lenghtArray)
        {
            double perimeter = 0;
            for (int i = 0; i < lenghtArray.Length; i++)
            {
                perimeter += lenghtArray[i];
            }
            Console.WriteLine("Периметр равен: " + perimeter);
        }
        public static void Main()
        {
            Console.WriteLine("Введите количесво углов фигуры -3-, -4-, -5- : ");

            int corner = Convert.ToInt32(Console.ReadLine());
            if (corner != 3 && corner != 4 && corner != 5)
                Console.WriteLine("Вы ввели недопустимое количество углов!");

            switch (corner)
            {
                case 3:
                    Console.WriteLine("Введите координатy X для первой точки: ");
                    double x1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координатy Y для первой точки: ");
                    double y1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите координатy X для второй точки: ");
                    double x2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координатy Y для второй точки: ");
                    double y2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите координатy X для третьей точки: ");
                    double x3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координатy Y для третьей точки: ");
                    double y3 = Convert.ToDouble(Console.ReadLine());

                    Point point1 = new Point(x1, y1);
                    Point point2 = new Point(x2, y2);
                    Point point3 = new Point(x3, y3);
                    double lenght1 = LenghtSide(point1, point2);
                    double lenght2 = LenghtSide(point2, point3);
                    double lenght3 = LenghtSide(point3, point1);
                    double[] array1 = new double[] { lenght1, lenght2, lenght3 };
                    Console.WriteLine("Фигура: Треугольник. ");
                    PerimeterCalculator(array1);
                    break;
                case 4:
                    Console.WriteLine("Введите координатy X для первой точки: ");
                    double x4 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координатy Y для первой точки: ");
                    double y4 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите координатy X для второй точки: ");
                    double x5 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координатy Y для второй точки: ");
                    double y5 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите координатy X для третьей точки: ");
                    double x6 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координатy Y для третьей точки: ");
                    double y6 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите координатy X для четвертой точки: ");
                    double x7 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координатy Y для четвертой точки: ");
                    double y7 = Convert.ToDouble(Console.ReadLine());

                    Point point4 = new Point(x4, y4);
                    Point point5 = new Point(x5, y5);
                    Point point6 = new Point(x6, y6);
                    Point point7 = new Point(x7, y7);

                    double lenght4 = LenghtSide(point4, point5);
                    double lenght5 = LenghtSide(point5, point6);
                    double lenght6 = LenghtSide(point6, point7);
                    double lenght7 = LenghtSide(point7, point4);

                    double[] array2 = new double[] { lenght4, lenght5, lenght6, lenght7 };
                    Console.WriteLine("Фигура: Прямоугольник. ");
                    PerimeterCalculator(array2);
                    break;
                case 5:
                    Console.WriteLine("Введите координатy X для первой точки: ");
                    double x8 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координатy Y для первой точки: ");
                    double y8 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите координатy X для второй точки: ");
                    double x9 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координатy Y для второй точки: ");
                    double y9 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите координатy X для третьей точки: ");
                    double x10 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координатy Y для третьей точки: ");
                    double y10 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите координатy X для четвертой точки: ");
                    double x11 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координатy Y для четвертой точки: ");
                    double y11 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите координатy X для пятой точки: ");
                    double x12 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координатy Y для пятой точки: ");
                    double y12 = Convert.ToDouble(Console.ReadLine());


                    Point point8 = new Point(x8, y8);
                    Point point9 = new Point(x9, y9);
                    Point point10 = new Point(x10, y10);
                    Point point11 = new Point(x11, y11);
                    Point point12 = new Point(x12, y12);


                    double lenght8 = LenghtSide(point8, point9);
                    double lenght9 = LenghtSide(point9, point10);
                    double lenght10 = LenghtSide(point10, point11);
                    double lenght11 = LenghtSide(point11, point12);
                    double lenght12 = LenghtSide(point12, point8);


                    double[] array3 = new double[] { lenght8, lenght9, lenght10, lenght11, lenght12 };
                    Console.WriteLine("Фигура: Пятигранник. ");
                    PerimeterCalculator(array3);
                    break;





            }
        }
    }
}
