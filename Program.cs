using System;

namespace ConosleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.

            //Random ran = new Random();
            //int[] mas = new int[22];
            //int sum = 0;
            //int count = 0;
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    mas[i] = ran.Next(300, 551);
            //    //Console.WriteLine($"mas[{i}] = {mas[i]} мм");
            //    sum += mas[i];
            //    count++;
            //}
            //double mid = sum / count;
            //Console.WriteLine($"Среднее количество осадков = {mid} мм\n");
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    if (mas[i] > mid)
            //    {
            //        double dif = mas[i] - mid;
            //        Console.WriteLine($"Отклонение = {dif}");
            //    }
            //    else if (mas[i] < mid)
            //    {
            //        double dif1 = mid - mas[i];
            //        Console.WriteLine($"Отклонение = {dif1}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Отклонение = 0");
            //    }
            //}
            //Console.ReadKey();

            //Задача 4.

            Random ran = new Random();
            int[] mas = new int[31];
            int sum = 0;
            int count = 0;
            int max = mas[0];
            int min = mas[0];
            int index = 0;
            int index1 = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = ran.Next(68, 71);
                Console.WriteLine($"mas[{i}] = {mas[i]}");
                sum += mas[i];
                count++;
                if (mas[i] > max)
                {
                    max = mas[i];
                    index = i;
                }
                else if (mas[i] < min)
                {
                    min = mas[i];
                    index1 = i;
                }
            }
            double mid = sum / count;
            Console.WriteLine($"Среднее значение ЗП = {mid} руб.");
            Console.WriteLine($"Максимальная ЗП в {index} равна {max} руб.");
            Console.WriteLine($"Минимальная ЗП в {index1} равна {min} руб.");
            Console.ReadKey();
        }
    }
}