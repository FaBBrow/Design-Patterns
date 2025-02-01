using UnityEngine;

public class Sword : MonoBehaviour,Iweapon
{
    private float baseDamage = 10f;
    public float getDamage()
    {
        return baseDamage;
    }

    public void attack(Ienemy enemy)
    {
        enemy.takeDamage(getDamage());
        Debug.Log("sword atagı");
    }
}
