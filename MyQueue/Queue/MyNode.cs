using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue.Queue
{
    internal class MyNode<T>
    {
        public T Data { get; set; }

        public MyNode<T> Next { get; set; }

        public MyNode()
        {

        }

        public MyNode(T data)
        {
            Data = data;
        }

    }
}
