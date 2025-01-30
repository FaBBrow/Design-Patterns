using UnityEngine;

public class WalkingState : Istate
{
    public void Handle(StateController stateControl)
    {
        if (BearMovement.instance.movement==Vector3.zero)
        {
            stateControl.SetState(new IdleState());
        }
        
    }

    public string toString()
    {
        return "Walk";
    }
}
