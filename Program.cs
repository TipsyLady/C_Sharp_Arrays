using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subjects = null; //одномерный масс
            int[][] marks = null; // двумерный масс

            Console.Write("Введите кол-во предметов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            subjects = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ввведите предмет ({i + 1}/{n}): ");
                subjects[i] = Console.ReadLine();
            }

            marks = new int[n][]; //выделить память под строки

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите кол-во оценок по предмету {subjects[i]}: ");
                int m = Convert.ToInt32(Console.ReadLine());
                marks[i] = new int[m];

                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Введите оценкку ({j + 1}/{m}): ");
                    marks[i][j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
            }

            Console.Clear();

            for (int i = 0; i < subjects.Length; i++)
            {
                Console.Write($"{subjects[i]}: ");
                foreach (int mark in marks[i])
                    Console.Write($"{mark} ");
                Console.WriteLine();
            }

            Console.WriteLine();
            //посчитать среднее значения
            double total_sum = 0;
            double Avg_All = 0;
            for (int i = 0; i < subjects.Length; i++)
            {
                double av = Math.Round(marks[i].Average(),2);
                total_sum += av;
                Console.WriteLine($"Средний балл по {subjects[i]}: {av}");
            }
            Avg_All = total_sum / subjects.Length;
            Avg_All = Math.Round(Avg_All, 2);
            //Console.WriteLine($"Общий средний балл по предметам: {Avg_All}");
            Console.WriteLine();

            double max = 0;
            double min = 6;

            for (int i = 0; i < subjects.Length; i++)
            {
                foreach (int mark in marks[i])
                {
                    if (mark > max)
                        max = mark;
                    if (mark < min)
                        min = mark;
                }

                Console.WriteLine($"Максимальная оценка по {subjects[i]}: {max}");
                Console.WriteLine("*******************************");
                Console.WriteLine($"Миниимальная оценка по {subjects[i]}: {min}");
                Console.WriteLine("*******************************");
                max = 0; min = 6;
            }

            int Marks_Q =0;

            for (int i = 0; i < subjects.Length; i++)
            {
                foreach (int mark in marks[i])
                    Marks_Q++;
            }

            if (Avg_All > 2.5 && Marks_Q>2)
                Console.WriteLine($"Средний балл по всем предметам равен {Avg_All}, количество оценок равно {Marks_Q}: Аттестован успешно!");
            else Console.WriteLine($"Средний балл по всем предметам равен {Avg_All}, количество оценок равно { Marks_Q}: Аттестация не пройдена!");

            Console.WriteLine();
           





        }
    }
}
