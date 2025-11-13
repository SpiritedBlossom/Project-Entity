using UnityEngine;

public class WeaponData
{
    private static float damage;
    private static int ammoCapacity;
    private static string weaponName;
    private static float range;

    public void InitializeWeaponData(WeaponSO weapon)
    {
        //data from SO, assign it
        damage = weapon.damage;
        ammoCapacity = weapon.ammoCapacity;
        weaponName = weapon.weaponName;
        range = weapon.range;
    }
}
