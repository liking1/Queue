using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_
{
    interface InterQueue<T>
    {
        void Add(T elem, T priority);
        T Extract();
        T Top();
        uint Size { get; }
    }
    class QueueClass<T> : InterQueue<T>//, IEnumerable<T>
    {
        public Node<T> Head;
        public Node<T> Tail;
        private uint size;

        public uint Size { get => size; }

        public void Add(T elem, T priority)
        {
            Node<T> node = new Node<T>(elem, priority);
            if (size == 0)
            {
                Head = Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
            size++;
        }

        public T Extract()
        {
            T temp = this.Top();
            Head = Head.Next;
            size--;
            return temp;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var temp = Head;
            while (temp != null)
            {
                yield return temp.Data;
                temp = temp.Next;
            }
        }

        public T Top()
        {
            return Head.Data;
        }

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
    }
    class Node<T>
    {
        public T Data;
        public T Prior;
        public Node(T data, T prior)
        {
            Data = data;
            Prior = prior;
        }
        public Node<T> Next { get; set; }
    }
}
