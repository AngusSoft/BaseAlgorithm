using System;

namespace SortAlgorithm
{
    /// <summary>
    /// 冒泡排序
    /// </summary>
    public class BubbleSort
    {
        public static void Sort(int[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                bool flag = false;
                for(int j = 0; j < array.Length - i - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        flag = true;
                    }
                }
                if (!flag) break;
            }
        }
    }
}
