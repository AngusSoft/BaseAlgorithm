using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SortAlgorithm
{
    public class InsertSort
    {
        public static void Sort(int[] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                var temp = array[i];
                int j = i - 1;
                while(j >= 0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
        }
    }
}
