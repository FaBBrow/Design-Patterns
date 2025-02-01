using UnityEngine;

public class Enemy : MonoBehaviour,Ienemy
{
    public float health=100f;
    public void takeDamage(float damage)
    {
        health -= damage;
        Debug.Log(health);
    }
}
