using System;

namespace StatePattern
{
    public class AIStateNone : AIState
    {
        public override AIStateType StateType { get { return AIStateType.None; } }

        public AIStateNone(Character character) : base(character)
        {
        }

        public override void CheckCondition()
        {
        }

        public override void RunAction()
        {
            _character.WriteLog("Info. run none.");
            _character.SetAIState(AIStateType.Idle);
        }
    }
}

