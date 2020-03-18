using UnityEngine;

//context menu in assets
[CreateAssetMenu(fileName ="New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject {
    //overwriting
    new public string name = "New Item";
    //item icons
    public Sprite icon = null;
    //base gear
    public bool isDefaultItem = false; 
    
    public virtual void Use()
    {
        //use the item
        //something might happen

        Debug.Log("using " + name);
    }

    public void RemoveFromInventory ()
    {
        Inventory.instance.Remove(this);
    }

}
