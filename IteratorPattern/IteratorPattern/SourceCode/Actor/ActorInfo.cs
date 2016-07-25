using System;

namespace IteratorPattern
{
    public struct ActorInfo
    {
        public int _id;
        public string _name;
        public int _actionAbility;

        public ActorInfo(int id, string name, int actionAbility)
        {
            _id = id;
            _name = name;
            _actionAbility = actionAbility;
        }

        public void Log()
        {
            Console.WriteLine(string.Format(
                "Actor Info - id : {0} / name : {1} / actionAbility : {2}",
                _id, _name, _actionAbility));
        }
    }
}

