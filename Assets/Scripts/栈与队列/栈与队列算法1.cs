using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 栈与队列算法1 : MonoBehaviour
{
    //  请你设计一个 最小栈。它提供 push、pop、top 操作，并能在常数时间内检索到最小元素。

    //实现 MinStack 类:
    //MinStack() 初始化堆栈对象。
    //void push(int val) 将元素 val 推入堆栈。
    //void pop() 删除堆栈顶部的元素。
    //int top() 获取堆栈顶部的元素。
    //int getMin() 获取堆栈中的最小元素。

    //示例：
    //MinStack minStack = new MinStack();
    //minStack.push(-2);
    //minStack.push(2);
    //minStack.push(-3);
    //minStack.getMin(); //--> 返回 -3.
    //minStack.pop();
    //minStack.top();    //--> 返回 2.
    //minStack.getMin(); //--> 返回 -2.

    class MinStack
    {
        Stack<int> A, B;
        public MinStack()
        {
            A = new Stack<int>();
            B = new Stack<int>();
        }
        public void Push(int val)
        {
            A.Push(val);
            if (B.Count == 0 || val <= B.Peek())
            {
                B.Push(val);
            }
        }

        public void Pop()
        {
            if (A.Pop() == B.Peek())
            {
                B.Pop();
            }
        }

        public int Top()
        {
            return A.Peek();
        }

        public int GetMin()
        {
            return B.Peek();
        }
    }
}
