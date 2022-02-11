using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pan : CookingItem
{
    public int itemID = 4;
    string name1 = "pan";

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

