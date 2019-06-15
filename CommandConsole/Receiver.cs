using System;

namespace CommandConsole
{
    public class Receiver : IReceiver
    {
        public void DoSomething(string str)
        {
            Console.WriteLine($"The receiver is { str } !!");
        }

        public void DoSomethingElse(string str)
        {
            Console.WriteLine($"The receiver is also { str } !");
        }
    }
}