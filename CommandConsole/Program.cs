using System;

namespace CommandConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           Invoker.SetStart(new StaticCommand("i'm so static"));
           
           Invoker.SetFinish(new ReceivedCommand(new Receiver(), new string[]
           {
               "first",
               "second",
               "third",
               "fourth",
               "fifth",
               "sixth"
           }));
           
           Invoker.DoItAll();
        }
    }
}