using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingItem : MonoBehaviour
{
    public GameObject gameManager;
    public GameManager gameManagerScript;

    public int currentItemID;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = gameManager.GetComponent<GameManager>();
    }

    public void PanelManager()
    {
        if (!gameManagerScript.foodCooked)
        {
            gameManagerScript.LastSelectedItem();

            gameManagerScript.currentItemID = currentItemID;

            gameManagerScript.ItemPanelManager();
        }
    }

    public void CookFood()
    {
        if (currentItemID == gameManagerScript.currentFoodID)
        {
            gameManagerScript.CookOK();
        }
        else
        {
            gameManagerScript.CookError();
        }

    }
}
