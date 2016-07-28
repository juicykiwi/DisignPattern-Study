using System;

namespace AdaptorPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Adaptor Pattern World!\n");

            Character npc = Character.Create(100, 100);
            Environment tree = Environment.Create(500, 500);

            npc.GetHit(50);
            tree.GetHit(70);

            SkillAllRecovery skillAllRecovery = new SkillAllRecovery(20);
            skillAllRecovery.AddTarget(npc);

            EnvironmentToCharacterAdaptor treeAdaptor = new EnvironmentToCharacterAdaptor(tree);
            skillAllRecovery.AddTarget(treeAdaptor);

            skillAllRecovery.Action();
        }
    }
}
