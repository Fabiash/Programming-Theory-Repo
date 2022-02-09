using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lastSelectedFoodID;
    public int currentFoodID;
    public int chosenFoodID;
    public string uppercaseName;
    public string lowercaseName;
    public GameObject gameManager;
    public GameObject[] panel;
    private GameManager gameManagerScript;
    public GameObject mainCamera;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LastSelectedFood()
    {
        lastSelectedFoodID = currentFoodID;
    }

    public void PanelManager()
    {

        if (lastSelectedFoodID != 0)
        {
            panel[lastSelectedFoodID - 1].SetActive(false);
        }

        panel[currentFoodID - 1].SetActive(true);
    }
}
