using System;
using System.Threading;
using System.Collections.Generic;

namespace StatePattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Character> characterList = new List<Character>();
            characterList.Add(new Character("Johnson", 10));
            characterList.Add(new Character("Anderson", 20));
            characterList.Add(new Character("Carter", 30));
            characterList.Add(new Character("Lucas", 27));
            characterList.Add(new Character("Samuel", 14));

            for (int index = 0; index < characterList.Count; ++index)
            {
                characterList[index].StartAI();
            }

            while (characterList.Count > 0)
            {
                for (int index = 0; index < characterList.Count; ++index)
                {
                    if (characterList[index].IsAlive == false)
                    {
                        characterList.Remove(characterList[index]);
                    }
                }

                Thread.Sleep(1000);
            }
        }
    }
}
