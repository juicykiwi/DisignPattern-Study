using System;
using System.Threading;

namespace CommandPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Command Pattern World!\n");

            Avatar avatar = new Avatar();

            AvatarMoveCommand moveCommandUp = new AvatarMoveCommand(avatar, 1, MoveDirection.Up);
            AvatarMoveCommand moveCommandDown = new AvatarMoveCommand(avatar, 1, MoveDirection.Down);
            AvatarMoveCommand moveCommandLeft = new AvatarMoveCommand(avatar, 1, MoveDirection.Left);
            AvatarMoveCommand moveCommandRight = new AvatarMoveCommand(avatar, 1, MoveDirection.Right);

            OrderManager.Instance.AddOrder(moveCommandUp);
            OrderManager.Instance.AddOrder(moveCommandUp);
            OrderManager.Instance.AddOrder(moveCommandDown);
            OrderManager.Instance.AddOrder(moveCommandLeft);
            OrderManager.Instance.AddOrder(moveCommandLeft);
            OrderManager.Instance.AddOrder(moveCommandLeft);
            OrderManager.Instance.AddOrder(moveCommandRight);

            OrderManager.Instance.Start(1000);
        }
    }
}
