using JetBrains.Annotations;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    private List<WeaponSO> weaponSO;
    private List<WeaponData> weaponData;
    private WeaponData activeWeapon;
    private int weaponIndex;

    public void InitializeWeapons()
    {
        foreach (WeaponSO weapon in weaponSO)
        {
            WeaponData newWeaponData = new WeaponData();
            newWeaponData.InitializeWeaponData(weapon);
            weaponData.Add(newWeaponData);
        }
    }

    public void SwitchWeapon(int index)
    {
        if(index <= weaponSO.Count)
        {
            weaponIndex = index;
            activeWeapon = weaponSO[index];
        }
    }

    public void NextWeapon()
    {
        if (weaponIndex == weaponSO.Count)
        {
            weaponIndex = 0;
        } else weaponIndex++;
        activeWeapon = weaponData[weaponIndex];
    }

    public void PreviousWeapon()
    {
        if (weaponIndex == 0)
        {
            weaponIndex = weaponSO.Count;
        }
        else weaponIndex--;
        activeWeapon = weaponData[weaponIndex];
    }

    private void InitializeWeapon(WeaponSO weapon)
    {
        //instantiate a new weaponData object, call WeaponData
        //WeaponData.Initialize pass through SO and assign it to activeWeapon
        //add it to weaponData
        WeaponData newWeaponData = new WeaponData();
        newWeaponData.InitializeWeaponData(weapon);
        weaponData.Add(newWeaponData);
        activeWeapon = weaponData;
    }

    public void ShootWeapon()
    {
        //raycast
        Ray ray = new Ray(transform.position, (Camera.main.transform.position));
        RaycastHit hitData; 
        if (Physics.Raycast(ray, out hitData, weaponData.range))
        {
            print("hit");
        }
    }

}
