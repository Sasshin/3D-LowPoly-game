using UnityEngine;

public class ItemPickup : Interactable {

    public Item item;

    public override void Interact()
    {
        //Call out virtual method from Interactable.cs
        base.Interact();

        PickUp();
    }

    void PickUp ()
    {
        //picking up item, showing its name
        Debug.Log("Picking up " + item.name);
        //Add item to inventory
        bool wasPickedUp = Inventory.instance.Add(item);
        //Remove item from scene
        if (wasPickedUp)
            Destroy(gameObject);
    }
}
