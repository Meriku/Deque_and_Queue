using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson34
{
    public class DuplexItem<T>
    {
        public T Data;

        public DuplexItem<T> Previous;
        public DuplexItem<T> Next;

        public DuplexItem(T data)
        {
            Data = data;
        }
    }
}
