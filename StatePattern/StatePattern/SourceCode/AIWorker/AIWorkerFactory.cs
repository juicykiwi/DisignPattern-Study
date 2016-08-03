using System;
using System.Collections;
using System.Collections.Generic;

namespace StatePattern
{
    public class AIWorkerFactory
    {
        public AIWorker Create(Character character)
        {
            return new AIWorker(character);
        }

        public List<AIWorker> Create(List<Character> characterList)
        {
            List<AIWorker> aiWorkerList = new List<AIWorker>();

            for (int index = 0; index < characterList.Count; ++index)
            {
                if (characterList[index] == null)
                    continue;
                
                aiWorkerList.Add(Create(characterList[index]));
            }

            return aiWorkerList;
        }
    }
}

