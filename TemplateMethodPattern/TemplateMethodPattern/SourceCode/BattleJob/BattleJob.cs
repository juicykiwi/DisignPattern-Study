using System;

namespace TemplateMethodPattern
{
    public abstract class BattleJob
    {
        public string Name { get; }

        public BattleJob(string name)
        {
            Name = name;
        }

        // Template Method Pattern
        public void PrepareBattle()
        {
            TakeWeapon();
            SetSkills();

            if (WantTakeItem() == true)
            {
                TakeItem();
            }
        }

        protected abstract void TakeWeapon();
        protected abstract void SetSkills();

        // Hook
        protected virtual bool WantTakeItem()
        {
            return false;
        }

        protected abstract void TakeItem();

        public void GoField(int fieldId)
        {
            Console.WriteLine(Name + " : " + fieldId.ToString() + " 번째 필드로 이동했습니다.");
        }
    }
}

