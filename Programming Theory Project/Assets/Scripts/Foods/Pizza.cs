using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : Food

{
    public int foodID = 1;
    string name1 = "pizza";
    string name2 = "Pizza";

    private void OnMouseDown()
    {
        currentFoodID = foodID;
        PanelManager();
    }

    public void SetFood()
    {
        Debug.Log("OK");
        gameManagerScript.lowercaseName = name1;
        gameManagerScript.uppercaseName = name2;
        ChangeCamera();
    }

}
