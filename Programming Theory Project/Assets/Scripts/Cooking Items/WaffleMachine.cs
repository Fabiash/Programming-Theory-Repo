using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaffleMachine : CookingItem
{
    public int itemID = 3;
    string name1 = "waffle machine";

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

