using System.Collections;
using UnityEngine;

public class DefendAbility : DragonAbilitys
{
    public override IEnumerator useAbility(Animator anim)
    {
        anim.SetBool("Defend",true);
        yield return null;
        anim.SetBool("Defend",false);
    }

    
   
}
