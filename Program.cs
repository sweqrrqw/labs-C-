using System;

namespace lab3._2
{
    class Point
    {
        public double coord_point_X, coord_point_Y;
    }

    // class Figure
    // {
    //     private string name_of_figure;
    //
    //     public virtual double CalcSquare()
    //     {
    //         return 0;
    //     }
    // }

    class Triangle
    {
        private static int n = 2;
        Point[] points = new Point[n+1];
        

       public void input_coord()
        {
            Console.WriteLine("Введите координаты точек треугольника ");
            for (int i = 0; i < n+1; i++)
            {
                points[i] = new Point();
                Console.Write($"Введите координату {i+1}-ого Х: ");
                points[i].coord_point_X = double.Parse(Console.ReadLine());
                Console.Write($"Введите координату {i+1}-ого Y: ");
                points[i].coord_point_Y = double.Parse(Console.ReadLine());
            }
        }
       public double Side_calc(Point A, Point B)
       {
           return Math.Sqrt(Math.Pow(A.coord_point_X - B.coord_point_X, 2) + Math.Pow(A.coord_point_Y - B.coord_point_Y,2));
           
       }
       public double Perimtr_calc()
       {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += Side_calc(points[i], points[i + 1]);
            }

            sum += Side_calc(points[n], points[0]);


            return sum;

       }
        


    }
    class Square
    {
        private static int n = 3;
        Point[] points = new Point[n+1];
        

        public void input_coord()
        {
            Console.WriteLine("Введите координаты точек четырехугольника:  ");
            for (int i = 0; i < n+1; i++)
            {
                points[i] = new Point();
                Console.Write($"Введите координату {i+1}-ого Х: ");
                points[i].coord_point_X = double.Parse(Console.ReadLine());
                Console.Write($"Введите координату {i+1}-ого Y: ");
                points[i].coord_point_Y = double.Parse(Console.ReadLine());
            }
        }
        public double Side_calc(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.coord_point_X - B.coord_point_X, 2) + Math.Pow(A.coord_point_Y - B.coord_point_Y,2));
           
        }
        public double Perimtr_calc()
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += Side_calc(points[i], points[i + 1]);
            }

            sum += Side_calc(points[n], points[0]);


            return sum;

        }
        

    }
    class Pentagon
    {
        private static int n = 4;
        Point[] points = new Point[n+1];
        

        public void input_coord()
        {
            Console.WriteLine("Введите координаты точек пятихугольника:  ");
            for (int i = 0; i < n+1; i++)
            {
                points[i] = new Point();
                Console.Write($"Введите координату {i+1}-ого Х: ");
                points[i].coord_point_X = double.Parse(Console.ReadLine());
                Console.Write($"Введите координату {i+1}-ого Y: ");
                points[i].coord_point_Y = double.Parse(Console.ReadLine());
            }
        }
        public double Side_calc(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.coord_point_X - B.coord_point_X, 2) + Math.Pow(A.coord_point_Y - B.coord_point_Y,2));
           
        }
        public double Perimtr_calc()
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += Side_calc(points[i], points[i + 1]);
            }

            sum += Side_calc(points[n], points[0]);


            return sum;

        }

    }
    class Hexagon
    {
        private static int n = 5;
        Point[] points = new Point[n+1];
        

        public void input_coord()
        {
            Console.WriteLine("Введите координаты точек шестихугольника:  ");
            for (int i = 0; i < n+1; i++)
            {
                points[i] = new Point();
                Console.Write($"Введите координату {i+1}-ого Х: ");
                points[i].coord_point_X = double.Parse(Console.ReadLine());
                Console.Write($"Введите координату {i+1}-ого Y: ");
                points[i].coord_point_Y = double.Parse(Console.ReadLine());
            }
        }
        public double Side_calc(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.coord_point_X - B.coord_point_X, 2) + Math.Pow(A.coord_point_Y - B.coord_point_Y,2));
           
        }
        public double Perimtr_calc()
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += Side_calc(points[i], points[i + 1]);
            }

            sum += Side_calc(points[n], points[0]);


            return sum;

        }

        public double Perimtr_calc(string A)
        {
            Console.WriteLine("Вычисляем периметр "+ A +"а");
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += Side_calc(points[i], points[i + 1]);
            }

            sum += Side_calc(points[n], points[0]);


            return sum;
        }
        
        

    }
    
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Triangle test = new Triangle();
            Square test1 = new Square();
            Pentagon test2 = new Pentagon();
            Hexagon test3 = new Hexagon();
            int number;
            while (true)
            {
                Console.WriteLine("Выберите действие");
                Console.WriteLine("1. Вычислить периметр треугольника: ");
                Console.WriteLine("2. Вычислить периметр четырехугольника: ");
                Console.WriteLine("3. Вычислить периметр пятиугольника: ");
                Console.WriteLine("4. Вычислить периметр шестиугольника: ");
                Console.WriteLine("5. Сравнить значения периметра треугольника и шестиугольника ");
                Console.WriteLine("0. Выход ");
                Console.Write("Введите число: ");
                number = Int32.Parse(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                switch (number)
                {
                    case 1:
                        test.input_coord();
                        Console.WriteLine("Периметр треугольника равен: "+ test.Perimtr_calc());
                        Console.ReadKey();
                        break;
                    case 2:
                        test1.input_coord();
                        Console.WriteLine("Периметр четырехугольника равен: "+ test1.Perimtr_calc());
                        Console.ReadKey();
                        break;
                    case 3:
                        test2.input_coord();
                        Console.WriteLine("Периметр пятиугольника равен: "+ test2.Perimtr_calc());
                        Console.ReadKey();
                        break;
                    case 4:
                        test3.input_coord();
                        test3.Perimtr_calc("Шестиугольник");
                        Console.WriteLine("Периметр шестиугольника равен: "+ test3.Perimtr_calc());
                        Console.ReadKey();
                        break;
                    case 5:
                        try
                        {
                            if (test.Perimtr_calc()<test3.Perimtr_calc())
                            {
                                Console.WriteLine("Периметр шестиугольника больше чем у треугольника");
                            }
                            else
                            {
                                Console.WriteLine("Периметр треугольника больше чем у шестиугольника");
                            }
                            Console.ReadKey();
                            break;
                        }
                        catch 
                        {
                            Console.WriteLine("Значения не найдены вернитесь назад");
                            Console.ReadKey();
                            break;
                        }
                        
                }
            }
        }
    }
}