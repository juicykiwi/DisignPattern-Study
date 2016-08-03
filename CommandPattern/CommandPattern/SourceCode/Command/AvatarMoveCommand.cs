using System;

namespace CommandPattern
{
    public class AvatarMoveCommand : Command
    {
        int _distance = 0;
        Avatar _avatar = null;
        MoveDirection _direction;

        public AvatarMoveCommand(Avatar avatar, int distance, MoveDirection direction)
        {
            _avatar = avatar;
            _distance = distance;
            _direction = direction;
        }
        
        public override void Execute()
        {
            if (_avatar == null)
            {
                Console.WriteLine("Error! AvatarMoveCommand : avatar is null in Execute()");
                return;
            }

            _avatar.Move(_distance, _direction);
        }
    }
}

