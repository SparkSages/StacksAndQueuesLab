namespace StacksAndQueuesLab
{
    public interface IQueue<T>
    {
        public void Enqueue(T item);
        public T Dequeue();
        public T Peek();
        public int Count { get; }
    }
}