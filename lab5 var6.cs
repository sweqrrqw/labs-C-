using System;


namespace lab4_var6
{
    class Triad
    {
        private double first_number;

        public double First
        {
            get => first_number;
            set => first_number = value;
        }

        private double second_number;

        public double Second
        {
            get => second_number;
            set => second_number = value;
        }

        private double third_number;

        public double Third
        {
            get => third_number;
            set => third_number = value;
        }
        // private double sum1 , sum2, sum3;

        public void init_numbers()
        {
            Console.WriteLine("Введите первое число: ");
            First = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            Second = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            Third = Double.Parse(Console.ReadLine());

        }

        public double Sum_of_numbers()
        {
            return First + Second + Third;

        }

        class Triangle : Triad
        {
            public double GetArea()
            {
                double p = Sum_of_numbers() / 2.0;
                return Math.Sqrt(p * (p - First) * (p - Second) * (p - Third));
            }

            public double GetAlpha()
            {
                return 180.0-GetBeta()-GetGamma();
            }

            public double GetBeta()
            {
                return Math.Asin(2.0*GetArea()/(Third*First))*180/Math.PI;
            }

            public double GetGamma()
            {
                return Math.Acos((Math.Pow(Third,2)-Math.Pow(First,2)-Math.Pow(Second,2))/(-2.0*First*Second))*180/Math.PI;
            }

        }

        internal class Program
        {

            public static void Main(string[] args)
            {
                Triangle test = new Triangle();
                test.init_numbers();
                Console.WriteLine(test.GetArea());
                Console.WriteLine(test.GetAlpha());
                Console.WriteLine(test.GetBeta());
                Console.WriteLine(test.GetGamma());

            }

        }
    }
}