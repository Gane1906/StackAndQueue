using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class StackImplementation
    {
        private Node top;
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} element is pushed into stack", value);
        }
        public void Display()
        {
            Node node = this.top;
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }
            Console.WriteLine();
        }

        public void Peek()
        {
            if (this.top == null)
                Console.WriteLine("Stack is empty");
            Console.WriteLine("value at Peek is {0}", this.top.data);
        }
        public void Pop()
        {
            if (this.top == null)
                Console.WriteLine("Stack is empty");
            Console.WriteLine("value popped is {0} ", this.top.data);
            this.top = this.top.next;
        }
    }
}
