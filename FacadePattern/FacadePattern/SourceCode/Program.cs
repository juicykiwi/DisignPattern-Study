using System;

namespace FacadePattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Pacade Pattern World!\n");

            StageControl stageControl = new StageControl();

            stageControl.ReadyStage(1);

            stageControl.StartStage();

            stageControl.EndStage();
        }
    }
}
