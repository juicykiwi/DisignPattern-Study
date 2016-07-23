using System;

namespace ProxyPattern
{
    public abstract class ProxySubject
    {
        public enum LoadState
        {
            None,
            Loading,
            Loaded,
        }
            
        protected LoadState _loadState = LoadState.None;
        public LoadState CurLoadState
        {
            get { return _loadState; }
            set { _loadState = value; }
        }

        public bool IsLoaded { get { return _loadState == LoadState.Loaded; } }
        public bool IsPossibleLoad { get { return _loadState == LoadState.None; } }

        protected string _text = "";
        public string Text
        { 
            get { return _text; } 
            set { _text = value; }
        }

        public abstract void Load();
        public abstract void PrintLoadedText();
    }
}

