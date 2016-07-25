using System;
using System.Collections;

namespace IteratorPattern
{
    public class ActorArrayIterator : IEnumerator
    {
        int _currentIndex = -1;

        ActorArray _array = null;

        public object Current
        {
            get
            {
                if (_currentIndex < 0 || _currentIndex >= _array.Count)
                {
                    Console.WriteLine("Invalid current value.");
                    return default(ActorInfo);
                }
                
                return _array[_currentIndex]; 
            }
        }

        public ActorInfo CurrentActorInfo
        {
            get
            { 
                if (_currentIndex < 0 || _currentIndex >= _array.Count)
                {
                    Console.WriteLine("Invalid current value.");
                    return default(ActorInfo);
                }

                return _array[_currentIndex]; 
            }
        }
            
        public ActorArrayIterator(ActorArray array)
        {
            if (array == null)
            {
                Console.WriteLine("Error! ActorArrayIterator(). array is null.");
                return;
            }

            _array = array;
        }
            
        public bool MoveNext()
        {
            if (_currentIndex + 1 >= _array.Count)
                return false;

            ++_currentIndex;
            return true;
        }

        public void Reset()
        {
            _currentIndex = 0;
        }
    }
}

