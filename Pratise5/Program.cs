using System;

namespace Практика_Задание_5_692з
{
    class Практика_Задание_5_692з
    {
        public static Random rand = new Random();
        static void Main()
        {
            Console.WriteLine("Задание 692з:\nДана действительная " +
                "квадратная матрица порядка n.\nНайти наибольшее из значений элементов" +
                ", расположенных в заштрихованной части матрицы\n");
            Console.Write("Введите значение порядка матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[n, n];
            Input(mas, n);
            Print(mas, n);
            MaxElem(mas, n);
            Console.ReadKey();
        }
        static void Input(int[,] mas, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = rand.Next(0, 100);
                }
            }
        }
        static void Print(int[,] mas, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void MaxElem(int[,] mas, int n)
        {
            int index_i = 0, index_j = 0;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((j >= 1) && (n - i <= j) && (mas[i, j] > max))
                    {
                        max = mas[i, j];
                        index_i = i;
                        index_j = j;
                    }
                }
            }
            Console.WriteLine($"Максимальный элемент: array [{index_i}, {index_j}] = {mas[index_i, index_j]}");
        }
    }
}
