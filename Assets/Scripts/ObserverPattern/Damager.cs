using UnityEngine;

public class Damager : MonoBehaviour,Iinteractable
{
    private float damage = 3f;
    
    
    public void interact()
    {
        PlayerStats.instance.takeDamage(damage);
    }
}
