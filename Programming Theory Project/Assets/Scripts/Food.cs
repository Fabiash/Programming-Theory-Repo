using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public int lastSelectedFoodID;
    public int currentFoodID;
    public int chosenFoodID;
    public string uppercaseName;
    public string lowercaseName;

    public GameObject[] panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PanelManager()
    {
        if (lastSelectedFoodID != 0)
        {
            panel[lastSelectedFoodID - 1].SetActive(false);
            panel[currentFoodID - 1].SetActive(true);
        }
    }
}
