using System.Collections;
using UnityEngine;

public class Poison : WeaponDecorater
{
    private float extradamage = 5;
    private float damagecount = 3;
    private float damageindex = 0;
    public Poison(Iweapon weapon) : base(weapon)
    {
        
    }

    public override float getDamage()
    {
        return base.getDamage();
    }

    public override void attack(Ienemy enemy)
    {
        base.attack(enemy);
        
        givePoisonDamage(enemy);
    }

    public void givePoisonDamage(Ienemy enemy)
    {
        for (int i = 0; i < 3; i++)
        {
            enemy.takeDamage(extradamage);
        }
    }
}
