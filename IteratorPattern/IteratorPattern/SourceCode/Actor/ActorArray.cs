using System;

namespace IteratorPattern
{
    public class ActorArray
    {
        ActorInfo[] _array = null;

        int _count = 0;
        public int Count { get { return _count; } }

        public ActorInfo this[int index]
        {
            get
            { 
                try
                {
                    if (index >= Count)
                    {
                        throw new Exception("Error! Invalid index reference.");
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    return default(ActorInfo);
                }

                return _array[index];
            } 
        }

        public ActorArray(int capacity = 2)
        {
            _array = new ActorInfo[capacity];
        }

        public void Add(ActorInfo actorInfo)
        {
            if (_count >= _array.Length)
                ExtendArray();

            _array[_count] = actorInfo;
            ++_count;
        }

        void ExtendArray()
        {
            ActorInfo[] extendArray = new ActorInfo[_array.Length * 2];

            for (int index = 0; index < _array.Length; ++index)
            {
                extendArray[index] = _array[index];
            }

            _array = extendArray;
        }

        public ActorArrayIterator Iterator()
        {
            return new ActorArrayIterator(this);
        }
    }
}

