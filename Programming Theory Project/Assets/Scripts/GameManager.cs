using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class GameManager : MonoBehaviour
{
    private int lastSelectedFoodID;
    public int currentFoodID;

    [SerializeField] private GameObject[] foodPanel;

    [SerializeField] private GameObject mainCamera;
    [SerializeField] private Text textToChange;

    private int lastSelectedItemID;
    public int currentItemID;

    [SerializeField] private GameObject[] itemPanel;

    [SerializeField] private GameObject cookingStatus;
    // ENCAPSULATION
    public bool foodCooked { get; private set; }
    [SerializeField] private GameObject quitRestart;

    public string foodName;
    public string itemName;

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
        quitRestart.SetActive(true);
    }

    public void CookError()
    {
        cookingStatus.GetComponent<Text>().text = "<color=red>You can't cook a " + foodName + " in the " + itemName +  "</color>";
        cookingStatus.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
