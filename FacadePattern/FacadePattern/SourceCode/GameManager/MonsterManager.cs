using System;

namespace FacadePattern
{
    public enum MonsterType
    {
        Slime,
        Orc,
    }

    public class MonsterManager : Singleton<MonsterManager>
    {
        public void Create(MonsterType type)
        {
            Console.WriteLine(string.Format(
                "MonsterManager : {0} 타입의 몬스터를 생성했습니다.",
                type.ToString()));
        }

        public void RemoveAll()
        {
            Console.WriteLine(string.Format(    
                "MonsterManager : 모든 몬스터를 제거했습니다."));
        }
    }
}

