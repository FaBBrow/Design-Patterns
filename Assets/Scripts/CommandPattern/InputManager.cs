using System;
using UnityEngine;


public class InputManager :MonoBehaviour
    {
        private invoker _invoker;
        [SerializeField] private PlayerMovement _playerMovement;
        private void Awake()
        {
            _invoker = new invoker();
        }

        public void RunCommand(PlayerMovement player, Vector3 movement)
        {
            if(player==null)return;

            ICommand command = new MoveCommand(player, movement);
            _invoker.ExecuteCommand(command);
        }
        public void OnLeftButtonClick()
        {
            RunCommand(_playerMovement, Vector3.left);
        }

        
        public void OnRightButtonClick()
        {
            RunCommand(_playerMovement, Vector3.right);
        }

        
        public void OnUpButtonClick()
        {
            RunCommand(_playerMovement, Vector3.up);
        }

        
        public void OnDownButtonClick()
        {
            RunCommand(_playerMovement, Vector3.down);
        }

        
        public void OnUndoButtonClick()
        {
            _invoker.UndoCommand();
           
        }
    }
