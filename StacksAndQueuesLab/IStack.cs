namespace StacksAndQueuesLab
{
    public interface IStack<T>
    {
        public void Push(T item);
        public T Pop();
        public T Peek();
        public int Count { get; }
    }
}