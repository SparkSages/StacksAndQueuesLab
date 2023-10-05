using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueuesLab
{
    public class MyQueue<T> : IQueue<T>
    {
        private readonly List<T> elements;
        public int Count => elements.Count;
        public MyQueue()
        {
            elements = new List<T>();
        }
        public T Dequeue()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Queue is empty!");
            T element = elements[0];
            elements.RemoveAt(0);
            return element;
        }
        public void Enqueue(T item)
        {
            elements.Add(item);
        }
        public T Peek()
        {
            return elements[0];
        }
    }
}
