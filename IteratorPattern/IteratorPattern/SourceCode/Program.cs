using System;

namespace IteratorPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ActorArray actorArray = new ActorArray();
            actorArray.Add(new ActorInfo(1, "json", 90));
            actorArray.Add(new ActorInfo(2, "ben", 50));
            actorArray.Add(new ActorInfo(3, "cruch", 70));
            actorArray.Add(new ActorInfo(4, "katy", 30));
            actorArray.Add(new ActorInfo(5, "ethen", 80));

            ActorArrayIterator iterator = actorArray.Iterator();

            while (iterator.MoveNext() == true)
            {
                iterator.CurrentActorInfo.Log();
            }
        }
    }
}
