using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingItem : MonoBehaviour
{
    [SerializeField] private GameObject gameManager;
    // ENCAPSULATION
    public GameManager gameManagerScript { get; private set; }

    public int currentItemID { get; protected set; }

    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = gameManager.GetComponent<GameManager>();
    }

    public void PanelManager()
    {
        // ABSTRACTION
        if (!gameManagerScript.foodCooked)
        {
            gameManagerScript.LastSelectedItem();

            gameManagerScript.currentItemID = currentItemID;

            gameManagerScript.ItemPanelManager();
        }
    }

    public void CookFood()
    {
        // ABSTRACTION
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
