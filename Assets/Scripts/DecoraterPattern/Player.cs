using UnityEngine;

public class Player : MonoBehaviour
{

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        Ienemy enemyy = new Enemy();
        Iweapon weapon = new Sword();
       

        weapon = new Poison(weapon);
        weapon.attack(enemyy);

    }

 
}
