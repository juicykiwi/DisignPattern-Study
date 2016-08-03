using System;

namespace CommandPattern
{
    public class NoCommand : Command
    {
        public override void Execute()
        {
            Console.WriteLine("NoCommand : Execute()");
        }
    }
}

