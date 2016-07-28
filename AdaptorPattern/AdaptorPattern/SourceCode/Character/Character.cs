using System;

namespace AdaptorPattern
{
    public class Character
    {
        public int Hp { get; set; }
        public int HpMax { get; set;}

        public static Character Create(int hp, int hpMax)
        {
            Character newCharacter = new Character()
                {
                    Hp = hp,
                    HpMax = hpMax
                };

            Console.WriteLine(string.Format(
                "Character가 {0} HP로 생성되었습니다.",
                newCharacter.Hp));

            return newCharacter;
        }

        public virtual void Heal(int recoveryHp)
        {
            Hp += recoveryHp;
            Hp = Math.Min(Hp, HpMax);

            Console.WriteLine(string.Format(
                "Character가 {0} 회복되어 HP가 {1} 되었습니다.",
                recoveryHp, Hp));
        }

        public void GetHit(int damage)
        {
            Hp -= damage;
            Hp = Math.Max(0, Hp);

            Console.WriteLine(string.Format(
                "Character가 {0} 피해를 입어 HP가 {1} 되었습니다.",
                damage, Hp));
        }
    }
}

