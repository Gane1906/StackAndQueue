using System;
namespace StackAndQueue
{
    public class Program
    {
        static void Main(String[] args)
        {
            /*StackImplementation stack = new StackImplementation();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            stack.Peek();
            stack.Pop();*/
            QueueImplementation queue=new QueueImplementation();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            queue.Dequeue();
        }
    }
}