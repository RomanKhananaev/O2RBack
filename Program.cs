using System;
static class Program
{
    public class LinkedList<T>
    {
        public Node<T> First { get; set; }
        public Node<T> Last { get; set; }
        private int Count;
        
        public LinkedList()
        {
            this.First = null;
            this.Last = null;
        }
        public class Node<T>
        {
            public T Data { get; set; }
            public Node<T> Next { get; set; }

            public Node(T data)
            {
                this.Data = data;
            }

        }
        public void clear()
        {
            this.First = null;
            this.Last = null;
        }

        public void add(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.First == null)
            {
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                this.Last.Next = newNode;
                Last = newNode;
            }
            Count++;
        }
        public void remove(T target)
        {
            Node<T> previus = First;
            Node<T> current = previus.Next;

            while (current != null && !current.Data.Equals(target))
            {
                previus = current;
                current = previus.Next;
            }

            if (current != null)
            {
                previus.Next = current.Next;
                this.Count--;
            }

        }
        public void printList()
        {
            Node<T> node = this.First;
            while (node.Next != null)
            {
                Console.Write(node.Data + " -> ");
                node = node.Next;
            }
            Console.Write(node.Data +"\n");
            
        }

        public int count()
        {
            return Count;
        }

        public T[] toArray()
        {
            T[] array = new T[Count];
            Node<T> node = this.First;
            for (int i = 0; i < Count; i++)
            {
                array[i] = node.Data;
                node = node.Next;
            }

            return array;

        }



    }
    static void Main(String[] args)
    {

        LinkedList<int> list = new LinkedList<int>();
        list.add(182);
        list.add(183);
        list.add(184);
        list.printList();
        Console.WriteLine("Linked list have " + list.count() + " nodes");
        list.remove(183);
        list.printList();
        Console.WriteLine("Linked list have " + list.count() + " nodes");
        //list.clear();
        //list.printList();
        //Console.WriteLine("Linked list have " + list.Count + " nodes");
        list.toArray();

        LinkedList<string> list2 = new LinkedList<string>();
        list2.add("Grandfather");
        list2.add("Father");
        list2.add("Son");
        list2.printList();
        Console.WriteLine("Linked list have " + list2.count() + " nodes");
        list2.remove("Father");
        list2.printList();
        Console.WriteLine("Linked list have " + list2.count() + " nodes");
        //list2.clear();
        list2.toArray();


        //list2.printList();
        //Console.WriteLine("Linked list have " + list2.Count + " nodes");
    }
}


