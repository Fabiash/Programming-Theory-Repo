using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toast : Food

{
    public int foodID = 2;
    string name1 = "toast";

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
