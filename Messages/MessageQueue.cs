using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public class MessageQueue<T>
    {
        public LinkedList<T> queue = new LinkedList<T>();
        public bool IsEmpty = true;

        public T Enqueue(T obj)
        {
            IsEmpty = false;
            queue.AddLast(obj);
            return obj;
        }

        public T Dequeue()
        {

            if (IsEmpty)
            {
                throw new EmptyQueueException();
            }
            
            T temp = queue.First();
            queue.RemoveFirst();
            if (queue.Count == 0)
            {
                IsEmpty = true;
            }
            return temp;

            
            
        }

    }
}
