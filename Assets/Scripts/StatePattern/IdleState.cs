using UnityEngine;

public class IdleState : Istate
{
    public void Handle(StateController stateControl)
    {
        Vector3 BearMove= BearMovement.instance.movement;
        bool bIdle = (BearMove == Vector3.zero);
       if (!bIdle)
       {
           stateControl.SetState(new WalkingState());
       }
        
    }

    public string toString()
    {
        return "Idle";
    }
}
