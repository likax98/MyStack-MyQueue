using System;
using System.Collections;

namespace Stack_Queue
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Queues");
            //Console.WriteLine("Original Queues");
            //Queue queue1 = new Queue();
            //queue1.Enqueue("Lika");
            ////queue1.Enqueue("Ana");
            ////queue1.Enqueue("Dato");
            ////queue1.Enqueue("Tornike");
            ////queue1.Enqueue("Beqa");
            ////queue1.Enqueue("Giorgi");
            ////queue1.Enqueue("Lado");
            ////queue1.Enqueue("Shota");
            ////queue1.Enqueue("Robo");
            //// queue1.Dequeue();
            ////while (queue1.Count > 0)
            ////{
            ////    Console.WriteLine(queue1.Dequeue());
            ////}

            //Console.WriteLine(queue1.Dequeue());
            //Console.WriteLine(queue1.Dequeue());

            //Console.WriteLine($"Queue Count = {queue1.Count}");
            //Console.WriteLine("Foreach");
            //foreach (var item in queue1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(queue1.Contains("Tornike"));
            //Console.WriteLine($"Peek {queue1.Peek()}");

            Console.WriteLine("\nMy Queues");
            MyQueue queue = new MyQueue();
            queue.Enqueue("Lika");
            //queue.Enqueue("Ana");
            //queue.Enqueue("Dato");
            //queue.Enqueue("Tornike");
            //queue.Enqueue("Beqa");
            //queue.Enqueue("Giorgi");
            //queue.Enqueue("Lado");
            //queue.Enqueue("Shota");
            //queue.Enqueue("Robo");
            queue.Dequeue();

            Console.WriteLine(queue.Dequeue());
           // Console.WriteLine(queue.Dequeue());
            //Console.WriteLine($"Queue Count = {queue.Count}");
            //Console.WriteLine("Foreach");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(queue.Contains("Tornike"));
            //Console.WriteLine($"Peek {queue.Peek()}");
            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            ////}
            //queue.Print();
            //Console.WriteLine($"Queue Count = {queue.Count}");

            //Console.WriteLine("Stacks");
            //Console.WriteLine("Original Stack");
            //Stack stack1 = new Stack();
            //stack1.Push("Lika");
            //stack1.Push("Ana");
            //stack1.Push("Dato");
            //stack1.Push("Tornike");
            //stack1.Push("Beqa");
            //stack1.Push("Giorgi");
            //stack1.Push("Lado");
            //stack1.Push("Shota");
            //stack1.Push("Robo");
            //stack1.Pop();
            //Console.WriteLine(stack1.Pop());
            //Console.WriteLine(stack1.Count);
            //while (stack1.Count > 0)
            //{
            //    Console.WriteLine(stack1.Peek());
            //}

            //Console.WriteLine("My Stack");
            //MyStack stack = new MyStack();
            //stack.Push("Lika");
            //stack.Push("Ana");
            //stack.Push("Dato");
            //stack.Push("Tornike");
            //stack.Push("Beqa");
            //stack.Push("Giorgi");
            //stack.Push("Lado");
            //stack.Push("Shota");
            //stack.Push("Robo");
            //stack.Pop();
            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Peek());
            //}

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Count);

            //stack.Print();
        }
    }
}