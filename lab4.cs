using System;
using System.Diagnostics;

namespace lab3._2
{
    class Point
    {
        private double coord_point_X;

        public double CoordPointX
        {
            get => coord_point_X;
            set => coord_point_X = value;
        }

        private double coord_point_Y;

        public double CoordPointY
        {
            get => coord_point_Y;
            set => coord_point_Y = value;
        }
    }
    
    class Triangle
    {
        private static int n = 2;
        Point[] points = new Point[n+1];
        Random random = new Random();

        public Triangle()
        {
            for (int i = 0; i < n+1; i++)
            {
                points[i] = new Point();
                points[i].CoordPointX = random.Next(7, 17);
                points[i].CoordPointY = random.Next(5, 15);
            }
        }

       public void input_coord()
        {
            Console.WriteLine("Введите координаты точек треугольника ");
            for (int i = 0; i < n+1; i++)
            {
                points[i] = new Point();
                Console.Write($"Введите координату {i+1}-ого Х: ");
                points[i].CoordPointX = double.Parse(Console.ReadLine());
                Console.Write($"Введите координату {i+1}-ого Y: ");
                points[i].CoordPointY = double.Parse(Console.ReadLine());
            }
        }
       public double Side_calc(Point A, Point B)
       {
           return Math.Sqrt(Math.Pow(A.CoordPointX - B.CoordPointX, 2) + Math.Pow(A.CoordPointY - B.CoordPointY,2));
           
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
        Random random = new Random();
        public Square()
        {
            for (int i = 0; i < n+1; i++)
            {
                points[i] = new Point();
                points[i].CoordPointX = random.Next(7, 17);
                points[i].CoordPointY = random.Next(5, 15);
                // Console.WriteLine($"{points[i].coord_point_X},{points[i].coord_point_Y}");
            }
        }
        

        public void input_coord()
        {
            Console.WriteLine("Введите координаты точек четырехугольника:  ");
            for (int i = 0; i < n+1; i++)
            {
                points[i] = new Point();
                Console.Write($"Введите координату {i+1}-ого Х: ");
                points[i].CoordPointX = double.Parse(Console.ReadLine());
                Console.Write($"Введите координату {i+1}-ого Y: ");
                points[i].CoordPointY = double.Parse(Console.ReadLine());
            }
        }
        public double Side_calc(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.CoordPointX - B.CoordPointX, 2) + Math.Pow(A.CoordPointX - B.CoordPointY,2));
           
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
                points[i].CoordPointX = double.Parse(Console.ReadLine());
                Console.Write($"Введите координату {i+1}-ого Y: ");
                points[i].CoordPointY = double.Parse(Console.ReadLine());
            }
        }
        public double Side_calc(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.CoordPointX - B.CoordPointX, 2) + Math.Pow(A.CoordPointY - B.CoordPointY,2));
           
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
                points[i].CoordPointX = double.Parse(Console.ReadLine());
                Console.Write($"Введите координату {i+1}-ого Y: ");
                points[i].CoordPointY = double.Parse(Console.ReadLine());
            }
        }
        public double Side_calc(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.CoordPointX - B.CoordPointX, 2) + Math.Pow(A.CoordPointY - B.CoordPointY,2));
           
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
    
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Triangle test = new Triangle();
            Square test1 = new Square();
            Pentagon test2 = new Pentagon();
            Hexagon test3 = new Hexagon();
            bool flag = false;
            int number;
            while (true)
            {
                flag = false;
                Console.WriteLine("1. Вычислить периметр треугольника ");
                Console.WriteLine("2. Вычислить периметр четырехугольника ");
                Console.WriteLine("3. Вычислить периметр пятиугольника ");
                Console.WriteLine("4. Вычислить периметр шестиугольника ");
                Console.WriteLine("5. Сравнить значения периметра треугольника и шестиугольника ");
                Console.WriteLine("0. Выход ");
                Console.WriteLine();
                Console.Write("Выберите действие: ");
                number = Int32.Parse(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                switch (number)
                {
                    case 1:
                        while (true)
                        {
                            if (flag) break;
                            Console.Write("1.Использовать значения по умолчанию  \n" +
                                          "2. Задать значения вручную \n" +
                                          "0. Назад \n \n" +
                                          "Выберите действие: ");
                            number = Int32.Parse(Console.ReadLine());
                            Console.WriteLine();
                            if (number == 0) 
                            {break;}
                            switch (number)
                            {
                                case 1:
                                    try
                                    {
                                        Console.WriteLine("Периметр треугольника равен: "+ test.Perimtr_calc());
                                        Console.WriteLine();
                                        flag = true;
                                        break;
                                    }
                                    catch 
                                    {
                                        Console.WriteLine("Значения не найдены");
                                        Console.WriteLine();
                                        flag = true;
                                        break;
                                    }
                                    
                                case 2:
                                    test.input_coord();
                                    Console.WriteLine("Периметр треугольника равен: "+ test.Perimtr_calc());
                                    Console.WriteLine();
                                    flag = true;
                                    break;
                            }
                        }
                        break;
                    case 2:
                        while (true)
                        {
                            if (flag) break;
                            Console.Write("1.Использовать значения по умолчанию  \n" +
                                          "2. Задать значения вручную \n" +
                                          "0. Назад \n \n" +
                                          "Выберите действие: ");
                            number = Int32.Parse(Console.ReadLine());
                            Console.WriteLine();
                            if (number == 0) 
                            {break;}
                            switch (number)
                            {
                                case 1:
                                    try
                                    {
                                        Console.WriteLine("Периметр четырехугольника равен: "+ test1.Perimtr_calc());
                                        Console.WriteLine();
                                        flag = true;
                                        break;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Значения не найдены");
                                        Console.WriteLine();
                                        flag = true;
                                        break;
                                    }
                                case 2:
                                    test1.input_coord();
                                    Console.WriteLine("Периметр четырехугольника равен: "+ test1.Perimtr_calc());
                                    Console.WriteLine();
                                    flag = true;
                                    break;
                            }
                        }
                        break;
                    case 3:
                        while (true)
                        {
                            if (flag) break;
                            Console.Write("1.Использовать значения по умолчанию  \n" +
                                          "2. Задать значения вручную \n" +
                                          "0. Назад \n \n" +
                                          "Выберите действие: ");
                            number = Int32.Parse(Console.ReadLine());
                            Console.WriteLine();
                            if (number == 0) 
                            {break;}
                            switch (number)
                            {
                                case 1:
                                    try
                                    {
                                        Console.WriteLine("Периметр пятиугольника равен: "+ test2.Perimtr_calc());
                                        Console.WriteLine();
                                        flag = true;
                                        break;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Значения не найдены");
                                        Console.WriteLine();
                                        flag = true;
                                        break;
                                    }
                                case 2:
                                    test2.input_coord();
                                    Console.WriteLine("Периметр пятиугольника равен: "+ test2.Perimtr_calc());
                                    Console.WriteLine();
                                    flag = true;
                                    break;
                            }
                        }
                        break;
                        
                    case 4:
                        while (true)
                        {
                            if (flag) break;
                            Console.Write("1.Использовать значения по умолчанию  \n" +
                                          "2. Задать значения вручную \n" +
                                          "0. Назад \n \n" +
                                          "Выберите действие: ");
                            number = Int32.Parse(Console.ReadLine());
                            Console.WriteLine();
                            if (number == 0) 
                            {break;}
                            switch (number)
                            {
                                case 1:
                                    try
                                    {
                                        Console.WriteLine("Периметр шестиугольника равен: "+ test3.Perimtr_calc());
                                        Console.WriteLine();
                                        flag = true;
                                        break;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Значения не найдены");
                                        Console.WriteLine();
                                        flag = true;
                                        break;
                                    }
                                case 2:
                                    test3.input_coord();
                                    Console.WriteLine("Периметр шестиугольника равен: "+ test3.Perimtr_calc());
                                    Console.WriteLine();
                                    flag = true;
                                    break;
                            }
                        }
                        break;
                    case 5:
                        
                        while (true)
                        {
                            if (flag)
                            {
                                break;
                            }
                            Console.WriteLine("Выберите 1-ую фигуру для сравнения их периметра \n");
                            Console.Write("1. Треугольник \n" +
                                          "2. Четырехугольник \n" +
                                          "3. Пятиугольник \n" +
                                          "4. Шестиугольник \n" +
                                          "0. Выход \n" +
                                          "Выберите действие ");
                            number = Int32.Parse(Console.ReadLine());
                            if (number == 0){ break;}

                            switch (number)
                            {
                              case 1:
                                  while (true)
                                  {
                                      if (flag) { break; }
                                      
                                      Console.WriteLine("Выберите 2-ую фигуру\n");
                                      Console.Write("1.Четырехугольник \n" +
                                                        "2. Пятиугольник \n" +
                                                        "3. Шестиугольник \n" +
                                                        "0. Выход \n" +
                                                        "Выберите действие ");
                                      number = Int32.Parse(Console.ReadLine());
                                      if (number == 0) { break;}

                                      switch (number)
                                      {
                                          case 1:
                                              if (test.Perimtr_calc()<test1.Perimtr_calc())
                                              {
                                                  Console.WriteLine("Периметр четырехугольника больше чем у треугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                              else
                                              {
                                                  Console.WriteLine("Периметр треугольника больше чем у четырехугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                          case 2:
                                              if (test.Perimtr_calc()<test2.Perimtr_calc())
                                              {
                                                  Console.WriteLine("Периметр пятиугольника больше чем у треугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                              else
                                              {
                                                  Console.WriteLine("Периметр треугольника больше чем у пятиугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                          case 3:
                                              if (test.Perimtr_calc()<test3.Perimtr_calc())
                                              {
                                                  Console.WriteLine("Периметр шестиугольника больше чем у треугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                              else
                                              {
                                                  Console.WriteLine("Периметр треугольника больше чем у шестиугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                      }
                                  } 
                                  break;
                              case 2:
                                  while (true)
                                  {
                                      if (flag) { break; }
                                      
                                      Console.WriteLine("Выберите 2-ую фигуру\n");
                                      Console.Write("1.Треугольник \n" +
                                                        "2. Пятиугольник \n" +
                                                        "3. Шестиугольник \n" +
                                                        "0. Выход \n" +
                                                        "Выберите действие ");
                                      number = Int32.Parse(Console.ReadLine());
                                      if (number == 0) { break;}

                                      switch (number)
                                      {
                                          case 1:
                                              if (test.Perimtr_calc()<test1.Perimtr_calc())
                                              {
                                                  Console.WriteLine("Периметр четырехугольника больше чем у треугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                              else
                                              {
                                                  Console.WriteLine("Периметр треугольника больше чем у четырехугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                          case 2:
                                              if (test1.Perimtr_calc()<test2.Perimtr_calc())
                                              {
                                                  Console.WriteLine("Периметр пятиугольника больше чем у четырехугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                              else
                                              {
                                                  Console.WriteLine("Периметр четырехугольника больше чем у пятиугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                          case 3:
                                              if (test1.Perimtr_calc()<test3.Perimtr_calc())
                                              {
                                                  Console.WriteLine("Периметр шестиугольника больше чем у четырехугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                              else
                                              {
                                                  Console.WriteLine("Периметр четырехугольника больше чем у шестиугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                      }
                                  } 
                                  break;
                              case 3:
                                  while (true)
                                  {
                                      if (flag) { break; }
                                      
                                      Console.WriteLine("Выберите 2-ую фигуру\n");
                                      Console.Write("1.Треугольник \n" +
                                                        "2. Четырехугольник \n" +
                                                        "3. Шестиугольник \n" +
                                                        "0. Выход \n" +
                                                        "Выберите действие ");
                                      number = Int32.Parse(Console.ReadLine());
                                      if (number == 0) { break;}

                                      switch (number)
                                      {
                                          case 1:
                                              if (test.Perimtr_calc()<test2.Perimtr_calc())
                                              {
                                                  Console.WriteLine("Периметр пятиугольника больше чем у треугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                              else
                                              {
                                                  Console.WriteLine("Периметр треугольника больше чем у пятиугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                          case 2:
                                              if (test1.Perimtr_calc()<test2.Perimtr_calc())
                                              {
                                                  Console.WriteLine("Периметр пятиугольника больше чем у четырехугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                              else
                                              {
                                                  Console.WriteLine("Периметр треугольника больше чем у пятиугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                          case 3:
                                              if (test2.Perimtr_calc()<test3.Perimtr_calc())
                                              {
                                                  Console.WriteLine("Периметр шестиугольника больше чем у пятиугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                              else
                                              {
                                                  Console.WriteLine("Периметр пятиугольника больше чем у шестиугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                      }
                                  } 
                                  break;
                              case 4:
                                  while (true)
                                  {
                                      if (flag) { break; }
                                      
                                      Console.WriteLine("Выберите 2-ую фигуру\n");
                                      Console.Write("1.Треугольник \n" +
                                                        "2. Четырехугольник \n" +
                                                        "3. Шестиугольник \n" +
                                                        "0. Выход \n" +
                                                        "Выберите действие ");
                                      number = Int32.Parse(Console.ReadLine());
                                      if (number == 0) { break;}

                                      switch (number)
                                      {
                                          case 1:
                                              if (test.Perimtr_calc()<test2.Perimtr_calc())
                                              {
                                                  Console.WriteLine("Периметр пятиугольника больше чем у треугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                              else
                                              {
                                                  Console.WriteLine("Периметр треугольника больше чем у пятиугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                          case 2:
                                              if (test1.Perimtr_calc()<test2.Perimtr_calc())
                                              {
                                                  Console.WriteLine("Периметр пятиугольника больше чем у четырехугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                              else
                                              {
                                                  Console.WriteLine("Периметр треугольника больше чем у пятиугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                          case 3:
                                              if (test2.Perimtr_calc()<test3.Perimtr_calc())
                                              {
                                                  Console.WriteLine("Периметр шестиугольника больше чем у пятиугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                              else
                                              {
                                                  Console.WriteLine("Периметр пятиугольника больше чем у шестиугольника \n");
                                                  flag = true;
                                                  break;
                                              }
                                      }
                                  } 
                                  break;
                            }
                        } 
                        break;
                }
            }
        }
    }
}