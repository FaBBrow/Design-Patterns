using UnityEngine;

public interface Istate
{
   void Handle(StateController stateControl);
   string toString();

}
