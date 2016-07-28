using System;

namespace AdaptorPattern
{
    public class SkillAllRecovery : Skill
    {
        public int RecoveryValue { get; protected set; }

        public SkillAllRecovery(int recoveryValue)
        {
            RecoveryValue = recoveryValue;
        }

        public override void Action()
        {
            RecoveryAll();
        }

        void RecoveryAll()
        {
            for (int index = 0; index < _target.Count; ++index)
            {
                _target[index].Heal(RecoveryValue);
            }
        }
    }
}

