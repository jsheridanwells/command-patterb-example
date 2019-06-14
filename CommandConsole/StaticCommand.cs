using System;

namespace CommandConsole
{
    public class StaticCommand : ICommand
    {
        private readonly string _message;

        public StaticCommand(string message) 
            => _message = message;

        public void Run()
        {
            Console.WriteLine($"I've been told to : { _message } !");
        }
    }
}