using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 数组算法2 : MonoBehaviour
{
    //设备中存有 n 个文件，文件 id 记于数组 docs。若文件 id 相同，则定义该文件存在副本。请返回任意存在的副本的文件 id。
    //示例 1：
    //输入：docs = [2, 5, 3, 0, 5, 0]
    //输出：0 或 5
    // 0 ≤ docs[i] ≤ n-1

    public int FindRepeatDoc(int[] docs)
    {
        int i = 0;
        while (i < docs.Length)
        {
            //当前位置正确
            if (docs[i] == i)
            {
                i++;
                continue;
            }
            //找到了重复
            if (docs[docs[i]] == docs[i])
            {
                return docs[i];
            }
            //交换
            int tmp = docs[i];
            docs[i] = docs[tmp];
            docs[tmp] = tmp;
        }
        return -1;
    }

    void Start()
    {
        int[] docs = { 2, 5, 3, 0, 5, 0 };

        int res = FindRepeatDoc(docs);

        Debug.Log(res);
    }
}
