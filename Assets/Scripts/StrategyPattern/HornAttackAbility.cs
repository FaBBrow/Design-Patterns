using System.Collections;
using UnityEngine;

public class HornAttackAbility : DragonAbilitys
{
    public override IEnumerator useAbility(Animator anim)
    {
        anim.SetBool("Horn",true);
        yield return null;
        anim.SetBool("Horn",false);

    }

   
  
}
