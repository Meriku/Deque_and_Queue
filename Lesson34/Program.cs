using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson34
{
    internal class Program
    {
        static void Main(string[] args)
        {



            var que = new Queue<int>();


            var duplexque = new DuplexLinkedDeque<int>();

            duplexque.PushFront(1);
            duplexque.PushFront(2);
            duplexque.PushFront(3);
            duplexque.PushFront(4);
            duplexque.PushFront(5);
            duplexque.PushBack(11);
            duplexque.PushBack(12);
            duplexque.PushBack(13);
            duplexque.PushBack(14);
            duplexque.PushBack(15);


            Console.WriteLine(duplexque.PopFront());
            Console.WriteLine(duplexque.PopFront());
            Console.WriteLine(duplexque.PopBack());
            Console.WriteLine(duplexque.PopBack());
            Console.WriteLine(duplexque.PopFront());
            Console.WriteLine(duplexque.PopBack());



            Console.ReadLine();

        }
    }
}
