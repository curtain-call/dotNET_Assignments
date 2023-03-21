using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_maxmin
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            Node<T> p = this.Head;
            while (p != null)
            {
                action(p.Data);
                p = p.Next;
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> test = new GenericList<int>();
            for(int x = 0; x < 10; x++)
            {
                test.Add(x);
            }

            // 求最大值
            Console.WriteLine("最大值：");
            int max = 0;
            test.ForEach(delegate (int i) { if (max < i) max = i; });
            Console.WriteLine(max);

            // 求最小值
            Console.WriteLine("最小值：");
            int min = 1000;
            test.ForEach(delegate (int i) { if (min > i) min = i; });
            Console.WriteLine(min);

            // 求和
            Console.WriteLine("和：");
            int sum = 0;
            test.ForEach(i => sum += i);
            Console.WriteLine(sum);
        }
    }
}
