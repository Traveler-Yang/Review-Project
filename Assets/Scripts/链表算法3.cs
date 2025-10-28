using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 链表算法3 : MonoBehaviour
{
    //题目三
    //请实现 copyRandomList 函数，复制一个复杂链表。在复杂链表中，每个节点除了有一个 next 指针指向下一个节点。
    //还有一个 random 指针指向链表中的任意节点或者 null。

    public class Node
    {
        public int data;//编号信息
        public Node next;//下个节点
        public Node random;//随机节点

        public Node(int data)
        {
            this.data = data;
            next = null;
            random = null;
        }
    }

    public Node CopyRandomList(Node head)
    {
        //首节点为空，链表为空
        if (head == null)
        {
            //返回空
            return null;
        }
        #region 第一步 复制节点并插入到原节点后面
        Node curr = head;
        while (curr != null)
        {
            Node copy = new Node(curr.data);
            copy.next = curr.next;//复制当前节点的下一个节点
            curr.next = copy;//将当前节点的下一个节点指向复制节点
            curr = copy.next;//移动到下一个原始节点
        }
        #endregion

        #region 第二步 设置随机节点
        curr = head;
        while (curr != null)
        {
            if (curr.random != null)
            {
                curr.next.random = curr.random.next;//设置复制节点的随机节点
            }
            curr = curr.next.next;//移动到下一个原始节点
        }
        #endregion

        #region 第三步 拆分链表
        curr = head;
        Node copyHead = head.next;//复制链表的头节点
        Node copyCurr = copyHead;//复制链表的当前节点
        while (curr != null)
        {
            curr.next = curr.next.next;//恢复原始链表的下一个节点
            curr = curr.next;//移动到下一个原始节点
            if (copyCurr.next != null)
            {
                copyCurr.next = copyCurr.next.next;//设置复制链表的下一个节点
                copyCurr = copyCurr.next;//移动到下一个复制节点
            }
        }
        return copyHead;//返回复制链表的头节点
        #endregion
    }

    void Print(Node head)
    {
        Node temp = head;
        while (temp != null)
        {
            Debug.Log(temp.data + "——" + (temp.random == null ? null : temp.random.data));
            temp = temp.next;
        }
    }

    private void Start()
    {
        Node n0 = new Node(7);
        Node n1 = new Node(3);
        Node n2 = new Node(1);
        Node n3 = new Node(0);
        Node n4 = new Node(2);

        n0.next = n1; n0.random = null;
        n1.next = n2; n1.random = n0;
        n2.next = n3; n2.random = n4;
        n3.next = n4; n3.random = n2;
        n4.random = n0;

        var rsl = CopyRandomList(n0);
        Print(rsl);
    }
}
