using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class 字符串算法1 : MonoBehaviour
{
    // 路径加密
    //假定一段路径记作字符串 path，其中以 "." 作为分隔符。现需将路径加密
    //加密方法为将 path 中的分隔符替换为空格 "." 请返回加密后的字符串。

    public string EncryptPath(string path)
    {
        StringBuilder res = new StringBuilder();
        foreach (var s in path.ToCharArray())
        {
            if (s == '.')
            {
                res.Append(' ');
            }
            else
            {
                res.Append(s);
            }
        }
        return res.ToString();
    }

    private void Start()
    {
        Debug.Log(EncryptPath("www.example.com.index.html"));
    }
}
