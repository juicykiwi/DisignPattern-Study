using System;

namespace StatePattern
{
    public class AIStateDie : AIState
    {
        public override AIStateType StateType { get { return AIStateType.Die; } }

        public AIStateDie(Character character) : base(character)
        {
        }

        public override void CheckCondition()
        {
        }

        public override void RunAction()
        {
            _character.WriteLog("Info. run die.");
        }
    }
}

