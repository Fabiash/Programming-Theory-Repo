using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waffle : Food

{
    // POLYMORPHISM
    [SerializeField] private int foodID = 3;
    [SerializeField] private string name1 = "waffle";

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
