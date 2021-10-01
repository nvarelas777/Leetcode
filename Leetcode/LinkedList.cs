using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode
{
    public class LinkedList<T>
    {
        public Node<T> head;
        public LinkedList(List<T> list)
        {
            head = new Node<T>(list[0]);
            var curr = head;
            for(int i = 1; i < list.Count; i++)
            {
                curr.next = new Node<T>(list[i]);
                curr = curr.next;
            }
        }   

        public Node<T> GetHead()
        {
            return head;
        }
        public void Print(Node<T> head)
        {
            while (head != null)
            {
                Console.WriteLine(head.value);
                head = head.next;
            }
        }
    }

    public class Node<T>
    {
        public Node<T> next = null;
        public T value;

        public Node(T value)
        {
            this.value = value;
        }
    }
}
