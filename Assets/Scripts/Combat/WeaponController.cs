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
    //WeaponSO List is initialized in the inspector
    public List<WeaponSO> weaponSO;
    //WeaponData List is initialized to prevent NullReference
    public List<WeaponData> weaponData = new List<WeaponData>();
    public WeaponData activeWeapon;
    public int weaponIndex;
    //Tester variable for InitializeWeapon
    public WeaponSO weaponTest;

    public void Start()
    {
        //Testing Initialize Weapons, Switch Weapon, and Shoot Weapon
        /*Debug.Log("WeaponSO List: " + weaponSO);
        InitializeWeapons();
        InitializeWeapon(weaponTest);
        Debug.Log("WeaponData List: " + weaponData);
        for(int i = -1; i <= weaponData.Count; i++)
        {
            SwitchWeapon(i);
        }
        ShootWeapon();*/
    }
    public void Update()
    {
        //Testing Previous and Next Weapon when left click or right click
        /*if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log("previous weapon!");
            PreviousWeapon();
        }
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            Debug.Log("next weapon!");
            NextWeapon();
        }*/
    }

    public void InitializeWeapons()
    {
        //Go through list of weaponSOs
        foreach (WeaponSO weapon in weaponSO)
        {
            //Instantiate a new weaponData item
            WeaponData newWeaponData = new WeaponData();
            //Initialize the new weaponData item
            newWeaponData.InitializeWeaponData(weapon);
            //Debug.Log(weapon.weaponName);
            //Debug.Log(newWeaponData.weaponName);
            //Add item to weaponData list, no need to update activeWeapon
            weaponData.Add(newWeaponData);
        }
    }

    public void SwitchWeapon(int index)
    {
        //If index is within range, set the new index to the current index
        if (index < weaponData.Count && index >= 0)
        {
            weaponIndex = index;
            //Set activeWeapon to weaponData at given index
            activeWeapon = weaponData[index]; 
            //Debug.Log("weapon switched: " + weaponIndex + " " + activeWeapon.weaponName);
        }
        //else Debug.Log("out of range, invalid");
    }

    public void NextWeapon()
    {
        //If index is at the end of the list, reset index to 0
        //Otherwise, increase index by 1
        if (weaponIndex == weaponData.Count-1)
        {
            weaponIndex = 0;
        } else weaponIndex++;
        //Set activeWeapon to weaponData at new index
        activeWeapon = weaponData[weaponIndex];
        //Debug.Log("Now: " + weaponIndex + " " + activeWeapon.weaponName);
    }

    public void PreviousWeapon()
    {
        //If index is at 0, reset index to the end of the list
        //Otherwise, decrease index by 1
        if (weaponIndex == 0)
        {
            weaponIndex = weaponData.Count-1;
        }
        else weaponIndex--;
        //Set activeWeapon to weaponData at new index
        activeWeapon = weaponData[weaponIndex];
        //Debug.Log("Now: " + weaponIndex + " " + activeWeapon.weaponName);
    }

    private void InitializeWeapon(WeaponSO weapon)
    {
        //Instantiate a new weaponData item
        WeaponData newWeaponData = new WeaponData();
        //Initialize the new weaponData item
        newWeaponData.InitializeWeaponData(weapon);
        //Set activeWeapon to the new weaponData item
        activeWeapon = newWeaponData;
        //Debug.Log(activeWeapon.weaponName);
        //Add item to weaponData list
        weaponData.Add(newWeaponData);
    }

    public void ShootWeapon()
    {
        //Create a new Ray that goes from the center of the main camera, forward
        Ray ray = new Ray(Camera.main.transform.position, (Camera.main.transform.forward));
        RaycastHit hitData;
        //Draws ray for visualization while shooting
        //Debug.DrawRay(ray.origin, ray.direction * 10);
        //Debug.Log("Shooting");
        //If the raycast hits an object within the weapon's range, do something
        if (Physics.Raycast(ray, out hitData, activeWeapon.range))
        {
            print("the ray hit something!");
        }
    }

}
