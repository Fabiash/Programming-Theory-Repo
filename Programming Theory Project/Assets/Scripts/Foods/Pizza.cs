using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : Food

{
    // POLYMORPHISM
    [SerializeField] private int foodID = 1;
    [SerializeField] private string name1 = "pizza";

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
