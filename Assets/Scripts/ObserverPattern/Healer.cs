using UnityEngine;

public class Healer : MonoBehaviour,Iinteractable
{
    public float heal = 5f;
    public void interact()
    {
        PlayerStats.instance.takeHeal(heal);
    }
}
