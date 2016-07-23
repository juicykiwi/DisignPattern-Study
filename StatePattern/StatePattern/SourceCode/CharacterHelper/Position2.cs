using System;

namespace StatePattern
{
    public enum Direction
    {
        Up,
        Down,
        Right,
        Left,
    }

    public struct Position2
    {
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Position2(int posX, int posY)
        {
            PosX = posX;
            PosY = posY;
        }

        public Position2(Position2 position)
        {
            PosX = position.PosX;
            PosY = position.PosY;
        }

        public void MoveUp(int distance = 1)
        {
            PosY += distance;
        }

        public void MoveDown(int distance = 1)
        {
            PosY -= distance;
        }

        public void MoveRight(int distance = 1)
        {
            PosX += distance;
        }

        public void MoveLeft(int distance = 1)
        {
            PosY -= distance;
        }

        public void Move(Direction direction, int distance = 1)
        {
            switch (direction)
            {
                case Direction.Up:
                    MoveUp(distance);
                    break;

                case Direction.Down:
                    MoveDown(distance);
                    break;

                case Direction.Right:
                    MoveRight(distance);
                    break;

                case Direction.Left:
                    MoveLeft(distance);
                    break;
            }
        }
    }
}

