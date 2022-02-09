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
    public GameObject gameManager;
    public GameObject[] panel;
    public GameManager gameManagerScript; 
    public GameObject mainCamera;

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

        gameManagerScript.PanelManager();
    }

    public void ChangeCamera()
    {
        
        panel[currentFoodID - 1].SetActive(false);
        mainCamera.transform.position= new Vector3(-1.98000002f, 35f, 4.5999999f);
    }
}
