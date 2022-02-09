using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toast : Food

{
    public int foodID = 2;
    string name1 = "toast";
    string name2 = "Toast";

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
