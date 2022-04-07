using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Items/Weapon")]
public class WeaponScriptable : EquippableScriptable
{
    public WeaponStats weaponStats;

    public override void UseItem(PlayerController playerController)
    {
        if (equipped)
        {
            playerController.weaponHolder.UnEquipWeapon();
            //unequip inventory
            //remove from controller
        }
        else
        {
            //invoke OnWeaponEquipped
            //Equip weapon from weapon holder on player controller!
            playerController.weaponHolder.EquipWeapon(this);
            //PlayerEvents.InvokeOnWeaponEquipped(itemPrefab.GetComponent<WeaponComponent>());
            //playerController.weaponHolder.equippedWeapon
        }

        base.UseItem(playerController);
    }
}
