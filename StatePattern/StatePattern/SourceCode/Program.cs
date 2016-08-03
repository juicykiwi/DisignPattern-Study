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

            List<AIWorker> aiWokerList = new AIWorkerFactory().Create(characterList);
            for (int index = 0; index < aiWokerList.Count; ++index)
            {
                AIWorkerManager.Instance.AddAIWoker(aiWokerList[index]);
            }

            AIWorkerManager.Instance.Start();

            while (characterList.Count > 0)
            {
                for (int index = 0; index < characterList.Count; ++index)
                {
                    if (characterList[index].IsAlive == false)
                    {
                        characterList.Remove(characterList[index]);
                    }
                }
            }

            AIWorkerManager.Instance.Stop();
        }
    }
}
