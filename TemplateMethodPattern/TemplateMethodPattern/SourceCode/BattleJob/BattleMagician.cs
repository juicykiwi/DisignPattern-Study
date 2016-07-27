using System;

namespace TemplateMethodPattern
{
    public class BattleMagician : BattleJob
    {
        public BattleMagician() : base("Magician") 
        {
        }

        protected override void TakeWeapon()
        {
            Console.WriteLine(Name + " 이(가) 지팡이를 챙겼습니다.");
        }

        protected override void SetSkills()
        {
            Console.WriteLine(Name + " 이(가) 파이어볼 스킬을 준비했습니다.");
            Console.WriteLine(Name + " 이(가) 아이스붐 스킬을 준비했습니다.");
        }

        // Hook
        protected override bool WantTakeItem()
        {
            Console.WriteLine(Name + " : 마나 회복 아이템을 챙기겠습니까? (y/n)");
            string command = Console.ReadLine();

            if (command.CompareTo("y") == 0)
                return true;

            return false;
        }

        protected override void TakeItem()
        {
            Console.WriteLine(Name + " 이(가) 마나 회복 아이템을 챙겼습니다.");
        }
    }
}

