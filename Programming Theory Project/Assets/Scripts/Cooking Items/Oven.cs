using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oven : CookingItem
{
    public int itemID = 1;
    string name1 = "oven";

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
