using System;

namespace StatePattern
{
    public class AIStateIdle : AIState
    {
        public override AIStateType StateType { get { return AIStateType.Idle; } }

        public AIStateIdle(Character character) : base(character)
        {
        }

        public override void CheckCondition()
        {
            AIStateType nextState = NextStateRandom();
            if (nextState == AIStateType.Idle)
                return;

            _character.SetAIState(nextState);
        }

        public override void RunAction()
        {
            _character.WriteLog("Info. run idle.");
        }

        protected AIStateType NextStateRandom()
        {
            AIStateType nextState = AIStateType.None;

            Random random = new Random();
            int randomValue = random.Next(0, 2);

            switch (randomValue)
            {
                case 1:
                    nextState = AIStateType.Move;
                    break;

                case 2:
                    nextState = AIStateType.Action;
                    break;

                default:
                    nextState = AIStateType.Idle;
                    break;
            }

            return nextState;
        }
    }
}

