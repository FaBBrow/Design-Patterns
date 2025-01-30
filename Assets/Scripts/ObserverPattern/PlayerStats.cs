using System;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats instance;
    private float health = 100f;

    private void Awake()
    {
        instance = this;
    }

    public event Action onHealthChanged;

    public float Health
    {
        get => health;
       
    }


    public void takeDamage(float damage)
    {
        health -= damage;
        onHealthChanged.Invoke();
    }

    public void takeHeal(float heal)
    {
        health += heal;
        onHealthChanged.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Iinteractable>()!=null)
        {
            other.GetComponent<Iinteractable>().interact();
        }
    }
}
