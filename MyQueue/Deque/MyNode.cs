namespace MyQueue.Deque
{
    internal class MyNode<T>
    {
        public T Data { get; set; }
        
        public MyNode<T> Next { get; set; }
        public MyNode<T> Previous { get; set; }

        public MyNode() { }
        public MyNode(T data) 
        {
            Data = data;
        }

    }
}
