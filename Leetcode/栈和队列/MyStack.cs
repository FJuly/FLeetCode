using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MyStack<T>
    {
        private Node<T> top = null;
        private int size = 0;

        /*入栈操作*/
        public void Push(T val)
        {
            Node<T> node = new Node<T>(val);
            node.next = top;
            top = node;
            size++;
        }

        /*出栈操作*/
        public T Pop()
        {
            if (size <= 0)
            {
               throw new Exception("stack is null");
            }
            else
            {
                T value = top.val;
                top = top.next;
                size--;
                return value;
            }
        }

        public bool IsEempty()
        {
            if (size == 0)
                return true;
            else
                return false;
        }
    }

    public class Node<T>
    {
        public T val;
        public Node<T> next;
        public Node(T val)
        {
            this.val = val;
        }
    }
}
