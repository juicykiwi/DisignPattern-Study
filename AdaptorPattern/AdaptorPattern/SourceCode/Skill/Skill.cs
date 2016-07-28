using System;
using System.Collections.Generic;

namespace AdaptorPattern
{
    public abstract class Skill
    {
        protected List<Character> _target = new List<Character>();
        
        public void AddTarget(Character target)
        {
            _target.Add(target);
        }

        public abstract void Action();
    }
}

