using System;
using System.Collections.Generic;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine();
            //SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 8);
            //Console.WriteLine(String.Join(",", SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 6)));

            var ll = new LinkedList<int>(new List<int> { 1, 2, 3, 4, 5 });
            var head1 = ll.head;
            var head2 = head1;

            var node3 = ll.GetHead();
            var node4 = node3;

            var node = new Node<int>(5);
            var node2 = node;
            node.next = new Node<int>(10);

            head1 = head1.next;
            node3 = node3.next;
            //head1 = head1.next
            Console.WriteLine(head1.value);
            Console.WriteLine(head2.value);
        }

        public static Node<int> oddEvenList(Node<int> head)
        {
            if (head != null)
            {

                Node<int> odd = head, even = head.next, evenHead = even;

                while (even != null && even.next != null)
                {
                    odd.next = odd.next.next;
                    even.next = even.next.next;
                    odd = odd.next;
                    even = even.next;
                }
                odd.next = evenHead;
            }
            return head;
        }
    }
}
