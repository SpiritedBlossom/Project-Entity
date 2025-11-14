using JetBrains.Annotations;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
using System;
using static UnityEngine.UI.Image;


public class WeaponController : MonoBehaviour
{
    [SerializeField]
    public List<WeaponSO> weaponSO;
    public List<WeaponData> weaponData = new List<WeaponData>();
    public WeaponData activeWeapon;
    public int weaponIndex;

    public void Start()
    {
        Debug.Log("WeaponSO List: " + weaponSO);
        InitializeWeapons();
        Debug.Log("WeaponData List: " + weaponData);
        for(int i = -1; i <= weaponSO.Count; i++)
        {
            SwitchWeapon(i);
        }
        ShootWeapon();
    }
    public void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log("previous weapon!");
            PreviousWeapon();
        }
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            Debug.Log("next weapon!");
            NextWeapon();
        }
    }

    public void InitializeWeapons()
    {
        foreach (WeaponSO weapon in weaponSO)
        {
            WeaponData newWeaponData = new WeaponData();
            newWeaponData.InitializeWeaponData(weapon);
            Debug.Log(weapon.weaponName);
            Debug.Log(newWeaponData.weaponName);
            weaponData.Add(newWeaponData);
        }
    }

    public void SwitchWeapon(int index)
    {
        if (index < weaponData.Count && index >= 0)
        {
            weaponIndex = index;
            activeWeapon = weaponData[index]; 
            Debug.Log("weapon switched: " + weaponIndex + " " + activeWeapon.weaponName);
        }
        else Debug.Log("out of range, invalid");
    }

    public void NextWeapon()
    {
        if (weaponIndex == weaponSO.Count-1)
        {
            weaponIndex = 0;
        } else weaponIndex++;
        activeWeapon = weaponData[weaponIndex];
        Debug.Log("Now: " + weaponIndex + " " + activeWeapon.weaponName);
    }

    public void PreviousWeapon()
    {
        if (weaponIndex == 0)
        {
            weaponIndex = weaponSO.Count-1;
        }
        else weaponIndex--;
        activeWeapon = weaponData[weaponIndex];
        Debug.Log("Now: " + weaponIndex + " " + activeWeapon.weaponName);
    }

    private void InitializeWeapon(WeaponSO weapon)
    {
        //instantiate a new weaponData object, call WeaponData
        //WeaponData.Initialize pass through SO and assign it to activeWeapon
        //add it to weaponData
        WeaponData newWeaponData = new WeaponData();
        newWeaponData.InitializeWeaponData(weapon);
        activeWeapon = newWeaponData;
        Debug.Log(activeWeapon.weaponName);
        weaponData.Add(newWeaponData);
    }

    public void ShootWeapon()
    {
        Debug.Log("Shooting");
        //raycast
        Ray ray = new Ray(Camera.main.transform.position, (Camera.main.transform.forward));
        RaycastHit hitData;
        Debug.DrawRay(ray.origin, ray.direction * 10);
        if (Physics.Raycast(ray, out hitData, activeWeapon.range))
        {
            print("the ray hit something!");
        }
    }

}
