using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            Arraymanager manager1 = new Arraymanager();

            manager1.name = "ArrayManagement";
            Console.WriteLine($"Class name is {manager1.name}");

            manager1.goal = "to do manipulations with array";
            Console.WriteLine($"Goal is {manager1.goal}");

            manager1.date = 1;
            Console.WriteLine($"I spent {manager1.date} hour for created it");

            Console.WriteLine($" Class {manager1.name} can perform a number of actions, some of them is");

            Console.WriteLine("Create two-dimensional array in any parametrs");
            manager1.CreateArray(4, 4, 10, 99);

            Console.WriteLine("Get max element of array");
            manager1.GetArrayMax(new int[4, 8]);

            Console.WriteLine("Get min element of array");
            manager1.GetArrayMin(new int[5, 6]);

            Console.WriteLine("Get diaganal elements of regular two-dimensional array");
            manager1.GetDiagonalElements(new int[8, 8]);

            Console.WriteLine("etc.");

            Printmanager manager2 = new Printmanager();
            manager2.name = "PrintManagment";
            manager2.Print(new int[4, 5]);
            manager2.Print(new int[5]);
            manager2.Print("Welcome to", 2022);

        }

        public class Arraymanager
        {
            public string name;
            public string goal;
            public int date;

            /// <summary>
            /// Create two-dimensional array from random digits from the interval you choose
            /// </summary>
            /// <returns>Return two-dimensional array</returns>
            public int[,] CreateArray(int heigth, int weigth, int randMinValue, int randMaxValue)
            {
                int[,] arr = new int[heigth, weigth];

                Random rd = new Random();

                if (randMaxValue > randMinValue)
                {
                    for (int i = 0; i < heigth; i++)
                    {
                        for (int j = 0; j < weigth; j++)
                        {
                            arr[i, j] = rd.Next(randMinValue, randMaxValue);
                        }
                    }
                }
                return arr;
            }

            /// <summary>
            /// Finds the max element of two-dimensional array 
            /// </summary>
            /// <param name="arr">given any array of Int32 type</param>
            /// <returns>Return maximum element of array</returns>
            public int GetArrayMax(int[,] arr)
            {
                int maxOfArr = arr[0, 0];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] > maxOfArr)
                        {
                            maxOfArr = arr[i, j];
                        }
                    }
                }
                return maxOfArr;
            }

            /// <summary>
            /// Finds the min element of two-dimensional array
            /// </summary>
            /// <param name="arr">given any array of Int32 type</param>
            /// <returns>Return minimum element of array</returns>
            public int GetArrayMin(int[,] arr)
            {
                int minOfArr = arr[0, 0];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] < minOfArr)
                        {
                            minOfArr = arr[i, j];
                        }
                    }
                }
                return minOfArr;
            }

            /// <summary>
            /// Finde indexes of the max element of two-dimensional array
            /// </summary>
            /// <param name="arr">given any array of Int32 type</param>
            /// <returns>Return indexes of the max element of array</returns>
            public (int, int) GetMaxIndex(int[,] arr)
            {
                int maxRowIndex = 0;
                int maxColIndex = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] > arr[maxRowIndex, maxColIndex])
                        {
                            maxRowIndex = i;
                            maxColIndex = j;
                        }
                    }
                }
                return (maxRowIndex, maxColIndex);
            }

            /// <summary>
            /// Finds indexes of the min element of two-dimensional array
            /// </summary>
            /// <param name="arr">given any array of Int32 type</param>
            /// <returns>Return indexes of the min element of array</returns>
            public (int, int) GetMinIndex(int[,] arr)
            {
                int minRowIndex = 0;
                int minColIndex = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] < arr[minRowIndex, minColIndex])
                        {
                            minRowIndex = i;
                            minColIndex = j;
                        }
                    }
                }
                return (minRowIndex, minColIndex);
            }

            /// <summary>
            /// Finds diagonal elements of regular two-dimensional array
            /// </summary>
            /// <param name="arr">given any array of Int32 type</param>
            /// <returns>Return one-dimensional array elements</returns>
            public int[] GetDiagonalElements(int[,] arr)
            {
                int[] diagonal = new int[arr.Length];
                if (arr.GetLength(0) == arr.GetLength(1))
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        diagonal[i] = arr[i, i];
                    }
                }
                return diagonal;
            }

            /// <summary>
            /// Finds max element of array
            /// </summary>
            /// <param name="arr">given diagonal array</param>
            /// <returns>return maximum element of array</returns>
            public int GetMaxOfArray(int[] arr)
            {
                int max = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
                return max;
            }


            /// <summary>
            /// Finds min element of array
            /// </summary>
            /// <param name="arr"></param>
            /// <returns>return minimum element of array</returns>
            public int GetMinOfArrey(int[] arr)
            {
                int min = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
                return min;
            }
        }
        public class Printmanager
        {
            public string name;
            /// <summary>
            /// Prints two-dimensional array elements in console
            /// </summary>
            /// <param name="arr">given any two-dimensional array of Int32 type</param>
            public void Print(int[,] arr)
            {

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write($"{arr[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }

            /// <summary>
            /// Prints diagonal elements of regular two-dimensional elements in console
            /// </summary>
            /// <param name="arr">given array of Int32 type</param>
            public void Print(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"{arr[i]} ");
                }
            }

            /// <summary>
            /// Print Int32 result from given parametrs
            /// </summary>
            /// <param name="value">given any Int32 value</param>
            public void Print(int value)
            {
                Console.WriteLine($"{value}");
            }

            /// <summary>
            /// Print string result from given parametrs
            /// </summary>
            /// <param name="name">given any string</param>
            /// <param name="value">given any Int32 value</param>
            public void Print(string name, int value)
            {
                Console.WriteLine($"{name} - {value}");
            }
        }
    }
}