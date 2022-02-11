using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waffle : Food

{
    public int foodID = 3;
    string name1 = "waffle";

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
