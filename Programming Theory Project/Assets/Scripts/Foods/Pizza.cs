using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : Food

{
    public int foodID = 1;
    string name1 = "pizza";

    private void OnMouseDown()
    {
        currentFoodID = foodID;
        PanelManager();
    }

    public void SetFood()
    {
        gameManagerScript.foodName = name1;
        gameManagerScript.ChangeCamera();
    }

}
