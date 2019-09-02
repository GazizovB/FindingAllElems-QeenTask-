using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueenTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //const int size = 9;
            //Random rand = new Random();
            //int[,] mas = new int[size, size];

            //////Отображение. Вывод на консоль
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        mas[i, j] = rand.Next() % 100;
            //        Console.Write(mas[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //  }

            const int size = 8;
            int[,] mas = new int[size, size] { { 1, 2, 3, 4, 5, 6, 7, 8 },
                                            { 9, 10, 11, 12, 13, 14, 15, 16 },
                                            { 17, 18, 19, 20, 21, 22, 23, 24 },
                                            { 25, 26, 27, 28, 29, 30, 31, 32 },
                                            { 33, 34, 35, 36, 37, 38, 39, 40 },
                                            { 41, 42, 43, 44, 45, 46, 47, 48 },
                                            { 49, 50, 51, 52, 53, 54, 55, 56 },
                                            { 57, 58, 59, 60, 61, 62, 63, 64 } };
            bool isNumber = false;

            ////Отображение. Вывод на консоль
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(mas[i, j] + "[" + i + "]" + "[" + j + "]" + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine("Enter your number:");
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (number == mas[i, j])
                    {
                        isNumber = true;
                    }
                }
            }


            if (isNumber)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (number == mas[i, j])
                        {
                            Console.Write(mas[i, j] + " " + "Pos:" + "[" + i + "]" + "[" + j + "]");
                            Console.WriteLine();

                            //Horizontal Combining
                            for (int jj = 0; jj < j; jj++)
                            {
                                //if (mas[i, j] == mas[i, jj])
                                //{
                                //    Console.WriteLine("Error!");
                                //}

                                Console.Write(mas[i, jj] + "\t");
                            }
                            for (int jj = j; jj < size; jj++)
                            {
                                Console.Write(mas[i, jj] + "\t");
                            }
                            Console.WriteLine();

                            //Vertical Combining
                            for (int ii = 0; ii < i; ii++)
                            {
                                Console.Write(mas[ii, j] + "\t");
                            }
                            for (int ii = i; ii < size; ii++)
                            {
                                Console.Write(mas[ii, j] + "\t");
                            }
                            Console.WriteLine();

                            //The main Diagonal
                            int l1 = i;
                            int m1 = j;

                            while (l1 > 0 && m1 > 0)
                            {
                                Console.Write(mas[l1 - 1, m1 - 1] + "\t");
                                l1--;
                                m1--;
                            }

                            int k = i;
                            int w = j;

                            while (k <= size - 1 && w <= size - 1)
                            {
                                Console.Write(mas[k, w] + "\t");
                                k++;
                                w++;
                            }
                            Console.WriteLine();

                            //The secondary Diagonal 
                            int l2 = i;
                            int m2 = j;

                            while (l2 <= size - 1 && m2 >= 0)
                            {
                                //if (mas[i, j] == mas[l2, m2])
                                //{
                                //    Console.WriteLine("Error!");
                                //    break;
                                //}
                                Console.Write(mas[l2, m2] + "\t");
                                l2++;
                                m2--;
                            }

                            int l3 = i;
                            int m3 = j;

                            while (l3 > 0 && m3 < size - 1)
                            {
                                Console.Write(mas[l3 - 1, m3 + 1] + "\t");
                                l3--;
                                m3++;
                            }
                            Console.WriteLine();
                            //Console.WriteLine();
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Не совпадает!");
            }
            //}

            Console.ReadLine();
        }
    }
}
