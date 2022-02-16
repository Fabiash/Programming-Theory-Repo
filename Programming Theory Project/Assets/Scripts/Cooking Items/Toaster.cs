using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toaster : CookingItem
{
    // POLYMORPHISM
    [SerializeField] private int itemID = 2;
    [SerializeField] private string name1 = "toaster";

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
