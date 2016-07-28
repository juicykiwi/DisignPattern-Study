using System;

namespace FacadePattern
{
    public enum CharacterType
    {
        Fighter,
        Archer,
        Magician,
    }
    
    public class CharacterManager : Singleton<CharacterManager>
    {
        public void Create(CharacterType type)
        {
            Console.WriteLine(string.Format(
                "CharacterManager : {0} 타입의 캐릭터를 생성했습니다.",
                type.ToString()));
        }

        public void RemoveAll()
        {
            Console.WriteLine(string.Format(    
                "CharacterManager : 모든 캐릭터를 제거해습니다."));
        }
    }
}

