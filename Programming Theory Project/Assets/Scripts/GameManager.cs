using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int lastSelectedFoodID;
    public int currentFoodID;
    public int chosenFoodID;
    public string foodName;
    public GameObject[] foodPanel;
    public GameObject mainCamera;
    public Text textToChange;
    public GameObject cookingStatus;
    public int currentItemID;
    public int lastSelectedItemID;
    public GameObject[] itemPanel;
    public string itemName;
    public bool foodCooked;
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

    public void FoodPanelManager()
    {

        if (lastSelectedFoodID != 0)
        {
            foodPanel[lastSelectedFoodID - 1].SetActive(false);
        }

        foodPanel[currentFoodID - 1].SetActive(true);
    }

    public void ChangeCamera()
    {
        foodPanel[currentFoodID - 1].SetActive(false);
        mainCamera.transform.position = new Vector3(31.04f, 10.8f, 9);
        mainCamera.transform.Rotate(-90, 270, 90);
        textToChange.text = "Choose where to cook\nyour " + foodName;
    }

    public void LastSelectedItem()
    {
        lastSelectedItemID = currentItemID;
    }

    public void ItemPanelManager()
    {

        if (lastSelectedItemID != 0)
        {
            itemPanel[lastSelectedItemID - 1].SetActive(false);
        }

        itemPanel[currentItemID - 1].SetActive(true);
    }

    public void CloseItemPanel()
    {
        itemPanel[currentItemID - 1].SetActive(false);
    }

    public void CookOK()
    {
        cookingStatus.GetComponent<Text>().text = "<color=white>OK!</color>";
        cookingStatus.SetActive(true);
        foodCooked = true;
        CloseItemPanel();
    }

    public void CookError()
    {
        cookingStatus.GetComponent<Text>().text = "<color=red>You can't cook a " + foodName + " in the " + itemName +  "</color>";
        cookingStatus.SetActive(true);
    }
}
