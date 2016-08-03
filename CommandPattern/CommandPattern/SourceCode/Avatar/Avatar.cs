using System;

namespace CommandPattern
{
    public enum MoveDirection
    {
        Up,
        Down,
        Left,
        Right
    }

    public class Avatar
    {
        public int PosX { get; protected set; }
        public int PosY { get; protected set; }

        protected void Translate(int x, int y)
        {
            PosX += x;
            PosY += y;
        }

        public void Move(int distance, MoveDirection direction)
        {
            switch (direction)
            {
                case MoveDirection.Up:
                    Translate(0, distance);
                    break;

                case MoveDirection.Down:
                    Translate(0, distance * -1);
                    break;

                case MoveDirection.Left:
                    Translate(distance * -1, 0);
                    break;

                case MoveDirection.Right:
                    Translate(distance, 0);
                    break;
            }

            Console.WriteLine("Avatar : 이동 완료 : Direction : {0} / x : {1} / y : {2}",
                direction.ToString(), PosX, PosY);
        }
    }
}

