using System;

namespace TemplateMethodPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello. Template Method Pattern World!\n");

            BattleKnight knight = new BattleKnight();
            knight.PrepareBattle();

            BattleMagician magician = new BattleMagician();
            magician.PrepareBattle();

            Console.WriteLine("\n준비된 영웅들이 필드로 이동합니다.\n");

            knight.GoField(1);
            magician.GoField(2);
        }
    }
}
