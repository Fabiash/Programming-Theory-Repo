using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public int lastSelectedFoodID;
    public int currentFoodID;
    public int chosenFoodID;
    public GameObject gameManager;
    public GameManager gameManagerScript; 

    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = gameManager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PanelManager()
    {
        gameManagerScript.LastSelectedFood();

        gameManagerScript.currentFoodID = currentFoodID;

        gameManagerScript.FoodPanelManager();
    }
}
