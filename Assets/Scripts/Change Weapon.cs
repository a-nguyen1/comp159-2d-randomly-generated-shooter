using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeapon : MonoBehaviour
{
    private GameObject PickUpWeapon;
    
    // Start is called before the first frame update
    void Start()
    {
        // if it's not the player, don't pick up item
        if (!other.CompareTag("Player")) return;

        GameObject PickUpWeapon = currentWeapon;

        if (weapon != null)
        {
            PickUpWeapon(currentWeapon);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void PickUpWeapon()
 //   {
        
 //   }
    
}


