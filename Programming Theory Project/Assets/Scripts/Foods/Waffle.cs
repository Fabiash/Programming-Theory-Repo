using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waffle : Food

{
    public int foodID = 3;
    string name1 = "waffle";
    string name2 = "Waffle";

    private void OnMouseDown()
    {
        currentFoodID = foodID;
        PanelManager();
    }

    public void SetFood()
    {
        gameManagerScript.lowercaseName = name1;
        gameManagerScript.uppercaseName = name2;
        ChangeCamera();
    }

}
