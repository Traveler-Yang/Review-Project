using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 数组算法3 : MonoBehaviour
{
    //给定一个二维数组 array，请返回【螺旋遍历】该数组的结果。
    //螺旋遍历：从左上角开始，按照向右、向下、向左、向上的顺序 依次 提取元素
    //然后再进入内部一层重复相同的步骤，直到提取完所有的元素为止。

    //示例 1：
    //输入：array = [[1,2,3],[8,9,4],[7,6,5]]
    //输出：[1,2,3,4,5,6,7,8,9]

    public int[] spriraLarray(int[][] array)
    {
        if (array.Length == 0)
        {
            return new int[0];
        }
        int left = 0;//左边界
        int right = array[0].Length - 1;//右边界
        int top = 0;//上边界
        int bottom = array.Length - 1;//下边界
        int x = 0;
        int[] res = new int[(right + 1) * (bottom + 1)];
        while (true)
        {
            for (int i = left; i <= right; i++)
            {
                res[x++] = array[top][i];
            }
            if (++top > bottom)
            {
                break;
            }
            for (int i = top; i <= bottom; i++)
            {
                res[x++] = array[i][right];
            }
            if (--right < left)
            {
                break;
            }

            for (int i = right; i >= left; i--)
            {
                res[x++] = array[bottom][i];
            }
            if (top > --bottom)
            {
                break;
            }
            for (int i = bottom; i >= top; i--)
            {
                res[x++] = array[i][left];
            }
            if (right < ++left)
            {
                break;
            }
        }
        return res;
    }

    void Start()
    {
        int[][] array = new int[][]{
            new int[] {1,2,3},
            new int[] {8,9,4},
            new int[] {7,6,5}
        };

        int[] res = spriraLarray(array);
    }
}
