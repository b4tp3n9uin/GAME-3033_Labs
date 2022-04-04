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
            //unequip inventory
            //remove from controller
        }
        else
        {
            //invoke OnWeaponEquipped
            //Equip weapon from weapon holder on player controller!
        }

        base.UseItem(playerController);
    }
}
