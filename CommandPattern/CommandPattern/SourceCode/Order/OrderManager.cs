using System;
using System.Threading;
using System.Collections.Generic;

namespace CommandPattern
{
    public class OrderManager
    {
        Queue<Command> _commandQueue = new Queue<Command>();

        static OrderManager _instance = null;
        public static OrderManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OrderManager();
                }

                return _instance;
            }
        }

        public void Start(int repeatOrderTime)
        {
            OrderPrecess(repeatOrderTime);
        }

        public void OrderPrecess(int repeatOrderTime)
        {
            while (_commandQueue.Count > 0)
            {
                Command command = _commandQueue.Dequeue();
                if (command != null)
                {
                    command.Execute();
                }

                Thread.Sleep(repeatOrderTime);
            }
        }

        public void AddOrder(Command command)
        {
            if (command == null)
            {
                Console.WriteLine("OrderManager : Error! command is null in AddOrder()");
                return;
            }

            _commandQueue.Enqueue(command);
        }
    }
}

