using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class invoker: MonoBehaviour
{
    
    private Stack<ICommand> undoStack = new Stack<ICommand>();


    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        undoStack.Push(command);

    }

  
    public void UndoCommand()
    {
        if (undoStack.Count > 0)
        {
            ICommand activeCommand = undoStack.Pop();

            activeCommand.Undo();
        }
        else
        {
            Debug.LogWarning("Nothing to UNDO!");
        }
    }
}
