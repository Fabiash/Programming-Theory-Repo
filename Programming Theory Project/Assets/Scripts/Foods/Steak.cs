using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steak : Food

{
    public int foodID = 4;
    string name1 = "steak";
    string name2 = "Steak";

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
