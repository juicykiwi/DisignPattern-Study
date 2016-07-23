using System;

namespace StatePattern
{
    public class AIStateAction : AIState
    {
        public override AIStateType StateType { get { return AIStateType.Action; } }

        public AIStateAction(Character character) : base(character)
        {
        }

        public override void CheckCondition()
        {
            _character.SetAIState(AIStateType.Idle);
        }

        public override void RunAction()
        {
            _character.WriteLog("Info. run action.");
        }
    }
}

