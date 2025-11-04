using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 数组算法1 : MonoBehaviour
{
    //数组 arrayA 记录了各个商品的数量
    //其中 arrayA[i] 表示第 i 个商品的数量
    //请返回一个数组 arrayB，该数组为基于 arrayA 中的数据计算得出的结果
    //其中 arrayB[i] 表示将第 i 个商品的数量从总体中排除后的其他数量的乘积
    //不能使用除法
    //输入：arrayA = [1, 2, 3, 4, 5]
    //输出：[120, 60, 40, 30, 24]

    public int[] generateArray(int[] arrayA)
    {
        int len = arrayA.Length;
        if (len == 0)
        {
            return new int[0];
        }
        int[] arrayB = new int[len];
        arrayB[0] = 1;
        //计算下三角
        for (int i = 1; i < len; i++)
        {
            arrayB[i] = arrayB[i - 1] * arrayA[i - 1];
        }
        int tmp = 1;
        //计算上三角
        for (int i = len - 2; i >= 0; i--)
        {
            tmp *= arrayA[i + 1];
            arrayB[i] *= tmp;
        }
        return arrayB;
    }

    private void Start()
    {
        int[] array = generateArray(new int[] { 1, 2, 3, 4, 5});
        foreach (var item in array)
        {
            Debug.Log(item);
        }
    }
}
