using System;

namespace ProxyPattern
{
    public class ProxyVirtualSubject : ProxySubject
    {
        ProxyRealSubject _realSubject = null;
        public ProxyRealSubject RealSubject { set { _realSubject = value; } }

        public new bool IsLoaded
        {
            get
            { 
                if (_realSubject == null)
                    return false;

                return _realSubject.IsLoaded;
            } 
        }

        public new bool IsPossibleLoad
        {
            get
            { 
                if (_realSubject == null)
                    return false;
                
                return _realSubject.IsPossibleLoad;
            } 
        }

        public ProxyVirtualSubject(ProxyRealSubject realSubject)
        {
            _realSubject = realSubject;
        }

        public override void Load()
        {
            if (_realSubject == null)
            {
                Console.WriteLine("Error! Real subject is null.");
                return;
            }

            if (_realSubject.IsPossibleLoad == false)
            {
                Console.WriteLine("Warning! Already real subject is loading or loaded.");
                return;
            }

            _realSubject.Load();
        }

        public override void PrintLoadedText()
        {
            if (_realSubject == null)
            {
                Console.WriteLine("Error! Real subject is null.");
                return;
            }

            if (_realSubject.IsLoaded == false)
            {
                Console.WriteLine("Warning! Not loaded real subject.");
                return;
            }

            _realSubject.PrintLoadedText();
        }
    }
}

