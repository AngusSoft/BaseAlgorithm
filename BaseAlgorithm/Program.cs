using Google.Protobuf.Collections;
using SortAlgorithm;
using System;
using System.Collections.Generic;

namespace BaseAlgorithm
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] array = new int[] { 15, 20, 7, 9, 24, 3 };
            SortAlgorithm(array);
            Console.ReadKey();
        }

        static void SortAlgorithm(int[] array)
        {
            BubbleSort.Sort(array);
            Console.WriteLine($"冒泡排序结果：{string.Join(",", array)}");

            QuickSort.Sort(array, 0, array.Length - 1);
            Console.WriteLine($"快速排序结果：{string.Join(",", array)}");

            InsertSort.Sort(array);
            Console.WriteLine($"插入排序结果：{string.Join(",", array)}");
        }
    }
}
