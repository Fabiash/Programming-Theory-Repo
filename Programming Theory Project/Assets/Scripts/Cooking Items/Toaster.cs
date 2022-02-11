using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toaster : CookingItem
{
    public int itemID = 2;
    string name1 = "toaster";

    private void OnMouseDown()
    {
        currentItemID = itemID;
        PanelManager();
    }

    public void SetItem()
    {
        gameManagerScript.itemName = name1;
        CookFood();
    }
}
