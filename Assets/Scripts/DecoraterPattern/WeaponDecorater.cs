using UnityEngine;

public  abstract class WeaponDecorater : MonoBehaviour,Iweapon
{
    protected Iweapon _weapon;

    public WeaponDecorater(Iweapon weapon)
    {
        _weapon = weapon;
    }
    public virtual float getDamage()
    {
        return _weapon.getDamage();
    }

    public virtual void attack(Ienemy enemy)
    {
        _weapon.attack(enemy);
    }
}
