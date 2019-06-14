using System;
using System.Runtime.CompilerServices;

namespace CommandConsole
{
    public static class Invoker
    {
        private static ICommand _start;
        private static ICommand _finish;

        public static void SetStart(ICommand command) 
            => _start = command;

        public static void SetFinish(ICommand command)
            => _finish = command;

        public static void DoItAll()
        {
            Console.WriteLine("Invoking....");
            if (_start is ICommand)
                _start.Run();
            
            Console.WriteLine("Halfway through invoking");
            if (_finish is ICommand)
                _finish.Run();
            
            Console.WriteLine("Done invoking");
        }
    }
}