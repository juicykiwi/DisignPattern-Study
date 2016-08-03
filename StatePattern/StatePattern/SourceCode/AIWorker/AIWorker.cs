using System;

namespace StatePattern
{
    public class AIWorker
    {
        Character _character = null;

        public AIWorker(Character character)
        {
            if (character == null)
            {
                Console.WriteLine("Error! AIWorker(). character is null.");
                return;
            }

            _character = character;
        }

        public void AIWork()
        {
            _character.AICurrentState.PassingTime();
            _character.AICurrentState.CheckCondition();
            _character.AICurrentState.RunAction();
        }

        public bool IsStopAIWorker()
        {
            return (_character.AICurrentState.StateType == AIStateType.Die);
        }
    }
}

