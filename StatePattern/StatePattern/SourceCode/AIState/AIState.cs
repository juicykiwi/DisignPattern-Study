using System;

namespace StatePattern
{
    public enum AIStateType
    {
        None,
        Idle,
        Move,
        Action,
        Die,
    }

    public abstract class AIState
    {
        protected Character _character = null;

        public abstract AIStateType StateType { get; }
        
        public AIState(Character character)
        {
            if (character == null)
            {
                Console.WriteLine("Error! AIState(). character is null.");
                return;
            }

            _character = character;
        }

        public void PassingTime()
        {
            _character.DecreaseLifeTime();
            if (_character.IsAlive == false)
            {
                _character.SetAIState(AIStateType.Die);
                return;
            }
        }

        public abstract void CheckCondition();
        public abstract void RunAction();
    }
}
