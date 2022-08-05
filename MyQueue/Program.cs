using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyQueue.Queue;
using MyQueue.Deque;

namespace MyQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var queue = new MyQueue<int>();
            //queue.Enqueue(1);
            //queue.Dequeue();
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Peek();
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue.Peek();
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Peek();
            //Console.WriteLine("Continue");
            //queue.Dequeue();


            var deque = new MyDeque<int>();
            deque.PushBack(4);
            deque.PushBack(5);
            deque.PushBack(6);
            deque.PushFront(3);
            deque.PushFront(2);
            deque.PushFront(1);

            deque.PopBack();
            deque.PopFront();
            deque.PopBack();
            deque.PopFront();
            deque.PopBack();
            deque.PopFront();
            deque.PopBack();
            deque.PeekBack();
            deque.PeekFront();

            Console.ReadLine();

        }
    }
}
