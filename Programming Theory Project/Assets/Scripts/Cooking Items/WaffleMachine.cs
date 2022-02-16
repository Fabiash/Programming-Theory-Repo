using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaffleMachine : CookingItem
{
    // POLYMORPHISM
    [SerializeField] private int itemID = 3;
    [SerializeField] private string name1 = "waffle machine";

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

