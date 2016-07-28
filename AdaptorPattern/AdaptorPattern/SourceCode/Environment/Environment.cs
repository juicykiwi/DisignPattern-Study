using System;

namespace AdaptorPattern
{
    public class Environment
    {
        public int Durability { get; protected set; }
        public int DurabilityMax { get; protected set; }

        public static Environment Create(int durability, int durabilityMax)
        {
            Environment newEnvironment = new Environment()
                {
                    Durability = durability,
                    DurabilityMax = durabilityMax
                };

            Console.WriteLine(string.Format(
                "Environment가 {0} 내구도로 생성되었습니다.",
                newEnvironment.Durability));

            return newEnvironment;
        }

        public void Repair(int recoveryDurability)
        {
            Durability += recoveryDurability;
            Durability = Math.Min(Durability, DurabilityMax);

            Console.WriteLine(string.Format(
                "Environment가 {0} 고쳐져서 내구도가 {1} 되었습니다.",
                recoveryDurability, Durability));
        }

        public void GetHit(int damage)
        {
            Durability -= damage;
            Durability = Math.Max(0, Durability);

            Console.WriteLine(string.Format(
                "Environment가 {0} 손상되어 내구도가 {1} 되었습니다.",
                damage, Durability));
        }
    }
}

