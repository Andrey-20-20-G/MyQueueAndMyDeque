using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue.Queue
{
    internal class MyQueue<T>
    {
        private MyNode<T> Head;
        private MyNode<T> Tail;

        public int Count { get; private set; }

        public MyQueue()
        {

        }

        public MyQueue(T data)
        {
           SetHeadAndTail(data);
        }

        protected void SetHeadAndTail(T data)
        {
            var node = new MyNode<T>(data);
            Head = node;
            Tail = node;
            Count = 1;
        }

        public void Enqueue(T data)
        {
            if (Count == 0)
            {
                SetHeadAndTail(data);
            }
            else
            {
                Tail.Next = new MyNode<T>(data);
                Tail = Tail.Next;
                Count++;
            }
        }

        public void Dequeue()
        {
            if(Count == 0)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                if(Count == 1)
                {
                    Console.WriteLine(Head.Data);
                    Head = null;
                    Tail = null;
                    Count = 0;
                }
                else
                {
                    Console.WriteLine(Head.Data);
                    Head = Head.Next;
                    Count--;
                }
            }
        }

        public void Peek()
        {
            if (Count > 0)
            {

                Console.WriteLine(Head.Data);
                return;
            }
            else
            {
                Console.WriteLine("Queue is empty");
            }
        }


    }
}