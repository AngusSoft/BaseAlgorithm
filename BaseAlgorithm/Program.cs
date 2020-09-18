using SortAlgorithm;
using System;

namespace BaseAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 15, 20, 7, 9, 24, 3};
            SortAlgorithm(array);
            Console.ReadKey();
        }

        static void SortAlgorithm(int[] array)
        {
            BubbleSort.Sort(array);
            Console.WriteLine($"冒泡排序结果：{string.Join(",", array)}");
        }
    }
}
