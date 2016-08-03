using System;
using System.Threading;
using System.Collections.Generic;

namespace StatePattern
{
    public class Character
    {
        protected int _lifeTime = 0;
        public bool IsAlive { get { return (_lifeTime > 0); } }

        protected string _name = "EmptyName";
        public string CharacterName { get { return _name; } }

        protected Position2 _pos;

        protected AIState _currentState = null;
        public AIState AICurrentState { get { return _currentState; } }

        protected Dictionary<AIStateType, AIState> _aiStateDict = new Dictionary<AIStateType, AIState>();

        public Character(string name, int lifeTime)
        {
            _name = name;
            _lifeTime = lifeTime;

            _aiStateDict.Add(AIStateType.None, new AIStateNone(this));
            _aiStateDict.Add(AIStateType.Idle, new AIStateIdle(this));
            _aiStateDict.Add(AIStateType.Move, new AIStateMove(this));
            _aiStateDict.Add(AIStateType.Action, new AIStateAction(this));
            _aiStateDict.Add(AIStateType.Die, new AIStateDie(this));

            _currentState = _aiStateDict[AIStateType.None];
        }

        public void SetAIState(AIStateType stateType)
        {
            if (_aiStateDict.ContainsKey(stateType) == false)
            {
                WriteLog("Error! SetAIState(). Not contains key : " + stateType.ToString()); 
                return;
            }

            WriteLog("Info. Changed ai : " + _currentState.StateType.ToString() + " to " + stateType.ToString());
            
            _currentState = _aiStateDict[stateType];
        }

        public void Move(Direction direction, int distance = 1)
        {
            _pos.Move(direction, distance);
        }

        public void DecreaseLifeTime()
        {
            if (_lifeTime <= 0)
                return;
            
            _lifeTime -= 1;
        }

        public void WriteLog(string message)
        {
            string log = string.Format("{0} ", CharacterName);
            log += message;

            Console.WriteLine(log);
        }
    }
}
