using System;

namespace CommandConsole
{
    public class ReceivedCommand : ICommand
    {
        private readonly IReceiver _receiver;
        private readonly string[] _messages;

        public ReceivedCommand(IReceiver receiver, string[] messages)
        {
            _receiver = receiver;
            _messages = messages;
        }
        public void Run()
        {
            for (var i = 0; i < _messages.Length; i++)
            {
                if (i % 2 == 0)
                {
                    _receiver.DoSomething(_messages[i]);
                }
                else
                {
                    _receiver.DoSomethingElse(_messages[i]); 
                } 
            }
        }
    }
}