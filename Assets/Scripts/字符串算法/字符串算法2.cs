using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 字符串算法2 : MonoBehaviour
{
    //  某公司门禁密码使用动态口令技术。初始密码为 password，密码更新遵循以下步骤：
    //  设定一个正整数目标值num
    //  将 password 前 num  个字符移动到字符串的尾部
    //  请返回更新后的密码字符串
    //  例：
    //  输入：password = "s3curltyc0d3", num = 4
    //  输出："rltyc0d3s3cu"
    //  0 <= num <= password.length

    public string UpdatePassword(string password, int num)
    {
        return password.Substring(num, password.Length - num) + password.Substring(0, num);
    }

    private void Start()
    {
        
    }
}
