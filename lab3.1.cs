using System;
using System.Text.RegularExpressions;

namespace LAB3
{
    class Student
    {
        public string name;
        private string surname;
        private string group;
        private int number_of_group;
        private double scholarship;
        Regex reg = new Regex(@"^\D+$");
        

        public void Input(int i)
        {
            Console.WriteLine($"Введите данные {i+1}-го студента");
            while (true)
            {
                Console.Write("Введите Имя: ");
                name = Console.ReadLine();
                if (reg.IsMatch(name) == true)
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("Введите фамилию: ");
                surname = Console.ReadLine();
                if (reg.IsMatch(surname) == true)
                {
                    break;
                }
            }
            while (true)
            {
                Console.Write("Введите Группу: ");
                group = Console.ReadLine();
                if (reg.IsMatch(group) == true)
                {
                    break;
                }
            }
            Console.Write("Введите номер группы: ");
            number_of_group = Int32.Parse(Console.ReadLine());
            Console.Write("Введите Стипендию:");
            scholarship = Double.Parse(Console.ReadLine());
          
        }

        public void Output(int i)
        {
            Console.WriteLine($"{i+1}.{name} {surname} {group}-{number_of_group} {scholarship}");
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number;
            Console.Write("Введите кол-во студентов ");
            number = Int32.Parse(Console.ReadLine());
            Student[] students = new Student[number];
          for (int i = 0; i < number; i++)
            { 
                students[i] = new Student();
                students[i].Input(i);
            }
            Console.WriteLine("Список студентов:");
          for (int i = 0; i < number; i++)
            {
                students[i].Output(i);
            }
            
            Console.ReadKey();
            
        }
    }
}