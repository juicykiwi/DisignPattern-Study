using System;

namespace AdaptorPattern
{
    public class EnvironmentToCharacterAdaptor : Character
    {
        Environment _environment = null;

        public EnvironmentToCharacterAdaptor(Environment environment)
        {
            _environment = environment;
        }

        public override void Heal(int recoveryHp)
        {
            _environment.Repair(recoveryHp);
        }
    }
}

