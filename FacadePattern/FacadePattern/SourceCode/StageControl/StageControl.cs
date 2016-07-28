using System;

namespace FacadePattern
{
    public class StageControl
    {
        public void ReadyStage(int level)
        {
            Console.WriteLine("\nStageControl : {0} 레벨 스테이지를 준비합니다.\n", level);

            FieldManager.Instance.Create(level);

            CharacterManager.Instance.Create(CharacterType.Fighter);
            CharacterManager.Instance.Create(CharacterType.Archer);
            CharacterManager.Instance.Create(CharacterType.Magician);

            MonsterManager.Instance.Create(MonsterType.Slime);
            MonsterManager.Instance.Create(MonsterType.Slime);
            MonsterManager.Instance.Create(MonsterType.Slime);
            MonsterManager.Instance.Create(MonsterType.Orc);
            MonsterManager.Instance.Create(MonsterType.Orc);

            Console.WriteLine("\nStageControl : 스테이지 준비가 완료되었습니다.\n");
        }

        public void StartStage()
        {
            Console.WriteLine("\nStageControl : 스테이지를 시작합니다.\n");
        }

        public void EndStage()
        {
            Console.WriteLine("\nStageControl : 스테이지를 종료합니다.\n");

            MonsterManager.Instance.RemoveAll();

            CharacterManager.Instance.RemoveAll();

            FieldManager.Instance.Remove();

            Console.WriteLine("\nageControl : 스테이지가 종료되었습니다.\n");
        }
    }
}

