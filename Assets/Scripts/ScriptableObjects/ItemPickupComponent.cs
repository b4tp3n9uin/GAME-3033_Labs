using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickupComponent : MonoBehaviour
{
    [SerializeField]
    ItemScript pickupItem;

    [Tooltip("Manual Override for drop amount, if left at -1 will use amount from Scriptable Object")]
    [SerializeField]
    int amount = -1;

    [SerializeField] MeshRenderer propMeshRenderer;
    [SerializeField] MeshFilter propFilter;

    ItemScript itemInstance;

    // Start is called before the first frame update
    void Start()
    {
        IntantiateItem ();
    }

    private void IntantiateItem()
    {
        itemInstance = Instantiate(pickupItem);
        if (amount > 0)
        {
            itemInstance.SetAmount(amount);
        }
        ApplyMesh();
    }

    void ApplyMesh()
    {
        if (propFilter) propFilter.mesh = pickupItem.itemPrefab.GetComponentInChildren<MeshFilter>().sharedMesh;
        if (propMeshRenderer) propMeshRenderer.materials = pickupItem.itemPrefab.GetComponentInChildren<MeshRenderer>().sharedMaterials;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        InventoryComponent playerInventory;
        playerInventory = other.GetComponent<InventoryComponent>();

        if (playerInventory) playerInventory.AddItem(itemInstance, amount);


        //add to inventory.
        //get reference to inventory.

        Destroy(gameObject);
    }
}
