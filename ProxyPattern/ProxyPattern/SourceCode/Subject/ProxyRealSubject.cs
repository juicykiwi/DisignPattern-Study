using System;
using System.Threading;

namespace ProxyPattern
{
    public class ProxyRealSubject : ProxySubject
    {
        public override void Load()
        {
            _loadState = LoadState.Loading;

            Thread threadLoad = new Thread(new ThreadStart(ThreadLoad));
            threadLoad.Start();
        }

        public override void PrintLoadedText()
        {
            Console.WriteLine(_text);
        }

        public void ThreadLoad()
        {
            Thread.Sleep(10000);

            _text = "Loaded real subject text!!!";
            _loadState = LoadState.Loaded;

            Console.WriteLine("Completed real subject ThreadLoad().");
        }
    }
}

