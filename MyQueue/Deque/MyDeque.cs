using System;
using System.Collections.Generic;

namespace MyQueue.Deque
{
    internal class MyDeque<T>
    {
        private MyNode<T> head;
        private MyNode<T> tail;
        public int Count { get; private set; }

        public MyDeque() { }

        public MyDeque(T data)
        {
            SetHeadAndTail(data);
        }

        private void SetHeadAndTail(T data)
        {
            var node = new MyNode<T>(data);

            head = node;
            tail = node;
            Count = 1;
        }

        public void PushFront(T data)
        {
            if (Count == 0)
            {
                SetHeadAndTail(data);
            }
            else
            {
                var current = head;
                var node = new MyNode<T>(data);
                head = node;
                head.Next = current;
                head.Next.Previous = node;
                Count++;
            }
        }

        public void PushBack(T data)
        {
            if(Count == 0)
            {
                SetHeadAndTail(data);
            }
            else
            {
                var current = tail;
                tail = new MyNode<T>(data)
                {
                    Previous = current
                };
                tail.Previous.Next = tail;
                Count++;                
            }
        }

        public void PeekBack()
        {
            if(Count > 0)    
            Console.WriteLine( tail.Data);
            else
                Console.WriteLine("Deque is empty");
            
        }

        public void PeekFront()
        {
            if(Count > 0)
                Console.WriteLine(head.Data);
            else
                Console.WriteLine("Deque is empty");
        }

        public void PopBack()
        {
            if(Count > 0)
            {
                PeekBack();
                if (Count == 1)
                {

                    head = null;
                    tail = null;
                    Count = 0;
                }
                else
                {
                    
                    tail = tail.Previous;
                    tail.Next = null;
                    tail.Previous.Next = tail;
                    Count--;
                }
            }
            else
            {

                Console.WriteLine("Deque is empty");
            }
        }

        public void PopFront()
        {
            if (Count > 0)
            {
                PeekFront();
                if (Count == 1)
                {
                    head = null;
                    tail = null;
                    Count = 0;
                }
                else
                {
                    
                    head = head.Next;
                    head.Previous = null;
                    head.Next.Previous = tail;
                    Count--;
                }
            }
            else
            {

                Console.WriteLine("Deque is empty");
            }
        }

    }
}
