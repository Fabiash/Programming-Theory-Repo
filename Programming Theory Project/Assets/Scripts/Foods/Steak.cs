using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steak : Food

{
    public int foodID = 4;
    string name1 = "steak";

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
