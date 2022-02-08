using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : Food
{
    public int foodID = 1;

    public void SetFood()
    {
        chosenFoodID = foodID;
        lowercaseName = "pizza";
        uppercaseName = "Pizza";
    }

}
