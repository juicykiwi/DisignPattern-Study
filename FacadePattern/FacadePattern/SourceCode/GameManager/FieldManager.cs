using System;

namespace FacadePattern
{
    public class FieldManager : Singleton<FieldManager>
    {
        public void Create(int index)
        {
            Console.WriteLine(string.Format(
                "FieldManager : {0} index 필드를 생성했습니다.",
                index));
        }

        public void Remove()
        {
            Console.WriteLine(string.Format(
                "FieldManager : 필드를 제거했습니다."));
        }
    }
}

