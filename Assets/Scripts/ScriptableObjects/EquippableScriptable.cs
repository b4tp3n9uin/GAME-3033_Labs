using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EquippableScriptable : ItemScript
{
    private bool isEquippped = false;

    public bool equipped
    {
        get => isEquippped;
        set {
            isEquippped = value;
            OnEquipStatusChange?.Invoke();
        }
    }

    public delegate void EquipStatusChange();
    public event EquipStatusChange OnEquipStatusChange;

    public override void UseItem(PlayerController playerController)
    {
        isEquippped = !isEquippped;
    }
}
