using System;
using System.Threading;

namespace ProxyPattern
{
    public class ProxyTestControl
    {
        public static void StartTest()
        {
            ProxyRealSubject realSubject = null;

            ProxyVirtualSubject virtualSubject = new ProxyVirtualSubject(realSubject);
            virtualSubject.Load();
            virtualSubject.PrintLoadedText();

            realSubject = new ProxyRealSubject();
            virtualSubject.RealSubject = realSubject;
            virtualSubject.Load();
            virtualSubject.Load();

            for (int loopCount = 0; loopCount < 100; ++loopCount)
            {
                virtualSubject.PrintLoadedText();

                if (virtualSubject.IsLoaded == true)
                    break;
                
                Thread.Sleep(1000);
            }
        }
    }
}

