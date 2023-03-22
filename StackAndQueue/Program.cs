using System;
namespace StackAndQueue
{
    public class Program
    {
        static void Main(String[] args)
        {
            StackImplementation stack = new StackImplementation();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
        }
    }
}