using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pan : CookingItem
{
    // POLYMORPHISM
    [SerializeField] private int itemID = 4;
    [SerializeField] private string name1 = "pan";

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

