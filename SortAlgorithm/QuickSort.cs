using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SortAlgorithm
{
    /// <summary>
    /// 快速排序
    /// </summary>
    public class QuickSort
    {
        public static void Sort(int[] array, int left, int right)
        {
            if(left < right)
            {
                var middleIndex = QueryIndex(array, left, right); //获取中位坐标
                Sort(array, left, middleIndex - 1); //比较左边的部分
                Sort(array, middleIndex + 1, right); //比较右边的部分
            }
        }

        private static int QueryIndex(int[] array, int left, int right)
        {
            //把第一个元素当作被比较的元素
            var temp = array[left];
            while(left < right)
            {
                //从右边直到找到比temp小的数跳出循环
                while (left < right && array[right] >= temp)
                    right--;
                array[left] = array[right];

                //从左边直到找到比temp大的数跳出循环
                while (left < right && array[left] <= temp)
                    left++;
                array[right] = array[left];
            }

            array[left] = temp;

            return left;
        }
    }
}
