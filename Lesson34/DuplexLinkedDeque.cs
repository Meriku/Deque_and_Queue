using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson34
{
    public class DuplexLinkedDeque<T>
    {
        DuplexItem<T> Head;
        DuplexItem<T> Tail;

        public int Count { get; private set; }

        public DuplexLinkedDeque()
        {
            Count = 0;
        }

        public DuplexLinkedDeque(T data)
        {
            SetHeadAndTail(data);
        }


        public void SetHeadAndTail(T data)
        {
            var item = new DuplexItem<T>(data);

            Head = item;
            Tail = item;
            
            Head.Next = Tail;
            Tail.Previous = Head;

            Count = 1;
        }

        public T PopBack()      // Забрать с хвоста
        {
            if (Count == 0)
            {
                throw new ArgumentNullException("Count");
            }

            var result = Tail.Data;

            Tail = Tail.Previous;
      
            Count--;

            return result;
        }


        public void PushBack(T data)  // Добавить с хвоста
        {
            if (Count == 0)
            {
                SetHeadAndTail(data);
                return;
            }

            var item = new DuplexItem<T>(data);

            item.Previous = Tail;
            item.Next = null;
            Tail.Next = item;

            Tail = item;
            Count++;
        }

        public T PopFront()     // Забрать с головы
        {
            if (Count == 0)
            {
                throw new ArgumentNullException("Count");
            }

            var result = Head.Data;

            Head = Head.Next;

            Count--;

            return result;
        }


        public void PushFront(T data) // Добавить с головы
        {
            if (Count == 0)
            {
                SetHeadAndTail(data);
                return;
            }

            var item = new DuplexItem<T>(data);

            item.Previous = null;
            item.Next = Head;
            Head.Previous = item;

            Head = item;
            Count++;

        }



    }
}
