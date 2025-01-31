using UnityEngine;

public class AbilityRunner : MonoBehaviour
{
    [SerializeField] private Animator anim;
    private DragonAbilitys currentAbility;

    public void useAbility()
    {
        StartCoroutine(currentAbility.useAbility(anim));
    }

    public void ClawButton()
    {
        currentAbility = new ClawAttackAbility();
        useAbility();
    }

    public void HornButton()
    {
        currentAbility = new HornAttackAbility();
        useAbility();
    }

    public void DefendButton()
    {
        currentAbility = new DefendAbility();
        useAbility();
    }
}
