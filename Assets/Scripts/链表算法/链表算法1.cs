using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 链表算法1 : MonoBehaviour 
{
    //题目一 图书整理
    //要求反转一个链表形式的书单
    //例：
    //输入：head = [1, 2, 3, 4]
    //输出：[4, 3, 2, 1]

    class Node
    {
        public int data;//编号信息
        public Node next;//下个节点
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
    class LinkedList
    {
        public Node head;//头节点
        public LinkedList()
        {
            head = null;
        }

        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="data"></param>
        public void Append(int data)
        {
            //每添加节点都是创建新的节点添加到链表的尾部
            //然后再将上个节点的next指向本节点
            Node newNode = new Node(data);
            if (head == null)//判断此节点是否是第一个节点
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)//判断是否到达链表的尾部
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }

        public void Reverse()
        {
            //反转的思路就是将链表中的每个节点的next节点指向前一个节点
            Node prev = null;//前一个节点
            Node curr = head;//当前节点
            Node next = null;//下一个节点
            while (curr != null)
            {
                next = curr.next;//先保存下一个节点，防止丢失
                curr.next = prev;//将当前节点的next指向当前节点的前一个节点

                //这里就相当于整体向右移动了一位
                prev = curr;//将前一个节点指向当前节点
                curr = next;//将当前节点指向下一个节点
            }
            head = prev;//最后将头节点指向最后一个节点
        }
        public void Print()
        {
            Node temp = head;
            while (temp != null)
            {
                Debug.Log(temp.data + "");
                temp = temp.next;
            }
        }
    }

    private void Start()
    {
        LinkedList list = new LinkedList();
        list.Append(1);
        list.Append(2);
        list.Append(3);
        list.Append(4);

        list.Print();
        list.Reverse();
        Debug.Log("反转后");
        list.Print();
    }
}
