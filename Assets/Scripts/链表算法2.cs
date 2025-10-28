using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 链表算法2 : MonoBehaviour 
{
    //题目二 
    //给定单向列表的头指针和一个要删除的节点的值，定义一个函数删除该节点。
    //输入：head = [4, 5, 1, 9]， val = 5
    //输出：[4, 1, 9]，该链表变为4 -> 1 -> 9

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
        public void Print()
        {
            Node temp = head;
            while (temp != null)
            {
                Debug.Log(temp.data + "");
                temp = temp.next;
            }
        }

        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="value">要删除的data</param>
        public void Delete(int value)
        {
            //校验判断，链表是否为null
            if (head == null)
            {
                return;
            }
            //判断当前要删除的值是否就是第一个节点
            if (head.data == value)
            {
                //如果是，则直接将第一个首节点指向下一个节点
                head = head.next;
                return;
            }
            //如果都不是则进行循环算法
            Node prev = head;//上一个节点
            Node curr = head.next;//当前节点
            while (curr != null)
            {
                //找到值后
                if (curr.data == value)
                {
                    //将上一个的next指针，赋值为下一个节点的next指针
                    prev.next = curr.next;
                    return;
                }
                //如果没有找到则继续向下遍历
                prev = curr;
                curr = curr.next;
            }
        }
    }

    private void Start()
    {
        LinkedList list = new LinkedList();
        list.Append(4);
        list.Append(1);
        list.Append(5);
        list.Append(9);

        list.Print();
        list.Delete(5);
        Debug.Log("删除后");
        list.Print();
    }
}
