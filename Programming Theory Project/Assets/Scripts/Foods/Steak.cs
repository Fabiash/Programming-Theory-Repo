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
        chosenFoodID = foodID;
        PanelManager();
    }

    public void SetFood()
    {
        lowercaseName = name1;
        uppercaseName = name2;
        ChangeCamera();
    }

}
