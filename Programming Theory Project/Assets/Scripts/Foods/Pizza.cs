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
