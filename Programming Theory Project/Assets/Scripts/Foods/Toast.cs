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
