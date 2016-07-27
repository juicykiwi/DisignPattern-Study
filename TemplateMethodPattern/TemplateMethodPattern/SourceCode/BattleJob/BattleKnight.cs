using System;

namespace TemplateMethodPattern
{
    public class BattleKnight : BattleJob
    {
        public BattleKnight() : base("Knight") 
        {
        }

        protected override void TakeWeapon()
        {
            Console.WriteLine(Name + " 이(가) 대검을 챙겼습니다.");
        }

        protected override void SetSkills()
        {
            Console.WriteLine(Name + " 이(가) 돌격 스킬을 준비했습니다.");
        }

        // Hook
        protected override bool WantTakeItem()
        {
            Console.WriteLine(Name + " : HP 회복 아이템을 챙기겠습니까? (y/n)");
            string command = Console.ReadLine();

            if (command.CompareTo("y") == 0)
                return true;

            return false;
        }

        protected override void TakeItem()
        {
            Console.WriteLine(Name + " 이(가) HP 회복 아이템을 챙겼습니다.");
        }
    }
}

