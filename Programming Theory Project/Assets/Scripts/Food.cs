using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] private GameObject gameManager;
    // ENCAPSULATION
    public GameManager gameManagerScript { get; private set; }

    public int currentFoodID { get; protected set; }

    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = gameManager.GetComponent<GameManager>();
    }

    public void PanelManager()
    {
        // ABSTRACTION
        gameManagerScript.LastSelectedFood();

        gameManagerScript.currentFoodID = currentFoodID;

        gameManagerScript.FoodPanelManager();
    }
}
