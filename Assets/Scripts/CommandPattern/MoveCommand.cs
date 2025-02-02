using UnityEngine;


    public class MoveCommand: ICommand
    {
        private PlayerMovement Player;
        private Vector3 movement;

        public MoveCommand(PlayerMovement player, Vector3 Movement)
        {
            this.Player = player;
            this.movement = Movement;
        }
        public void Execute()
        {
          Player.Move(movement);
        }

        public void Undo()
        {
            Player.Move(-movement);
        }
    }
