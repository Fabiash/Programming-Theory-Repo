using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toast : Food

{
    // POLYMORPHISM
    [SerializeField] private int foodID = 2;
    [SerializeField] private string name1 = "toast";

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
