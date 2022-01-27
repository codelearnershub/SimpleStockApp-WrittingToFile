using StockMSFile.Menus;
using StockMSFile.Repositories;
using System;

namespace StockMSFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //MainMenu mainMenu = new MainMenu();
            //mainMenu.Menu();

            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            int n = arr.Length;
            bubbleSort(arr, n);
            Console.WriteLine(string.Join(", ", arr));
        }

        static int[] bubbleSort(int[] arr, int n)
        {
            int i, j, temp;
            bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap arr[j] and arr[j+1]
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were 
                // swapped by inner loop, then break
                if (swapped == false)
                    break;
            }
            return arr;
        }
    }
}
