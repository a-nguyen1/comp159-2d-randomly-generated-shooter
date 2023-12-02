using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeapon : MonoBehaviour
{
    private GameObject weapon;
    public GameObject currentWeapon;
    public GameObject newWeapon;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject weapon = GetNewWeapon;

        //checks that the weapon is found
        if (currentWeapon != null)
        {
            //call method to pick up new weapon
            PickUpWeapon(newWeapon);
            
        }
    }

    void Update()
    {
        // if it's not the player, don't pick up item
        if (!other.CompareTag("Player")) return;
    }
    private GameObject PickUpWeapon()
    {
        //if the player collides with the a weapon, deactivate current weapon and activate new item
        if (PickUpWeapon = true)
        {
            currentWeapon.SetActive(false);
            newWeapon.SetActive(true);
        }
    }

}


