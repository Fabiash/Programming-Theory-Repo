using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oven : CookingItem
{
    // POLYMORPHISM
    [SerializeField] private int itemID = 1;
    [SerializeField] private string name1 = "oven";

    private void OnMouseDown()
    {
        // INHERITANCE
        currentItemID = itemID;
        PanelManager();
    }

    public void SetItem()
    {
        gameManagerScript.itemName = name1;
        // INHERITANCE
        CookFood();
    }
}
