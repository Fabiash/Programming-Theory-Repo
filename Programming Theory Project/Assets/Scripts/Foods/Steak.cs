using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steak : Food

{
    // POLYMORPHISM
    [SerializeField] private int foodID = 4;
    [SerializeField] private string name1 = "steak";

    private void OnMouseDown()
    {
        // INHERITANCE
        currentFoodID = foodID;
        PanelManager();
    }

    public void SetFood()
    {
        gameManagerScript.foodName = name1;
        gameManagerScript.ChangeCamera();
    }

}
