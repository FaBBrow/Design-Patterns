using System.Collections;
using UnityEngine;

public class ClawAttackAbility : DragonAbilitys
{
    public override IEnumerator useAbility(Animator anim)
    {
        anim.SetBool("Claw",true);
        yield return null;
        anim.SetBool("Claw",false);
    }

  

   
}
