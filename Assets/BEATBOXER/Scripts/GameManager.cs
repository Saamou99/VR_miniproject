using System.Net.Mime;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    [SerializeField] private int boxesInLevel = 100; 
    [SerializeField] private CubeSpawner cubeSpawner; 

    public int BoxesInLevel => boxesInLevel; 

    private int cubeCount; 
    private bool allCubesSpawned = false; 

    [SerializeField] private GameObject winText;
    [SerializeField] private GameObject playerHUD;
    
    [SerializeField] private Text boxesHit;
    [SerializeField] private Text boxesMissed;
    [SerializeField] private Text boxesHitText;
    [SerializeField] private Text boxesMissedText;
    
    
    



    private void OnEnable()
    {
        cubeSpawner.OnSpawningComplete += AllCubesInLevelSpawned;
    }

    private void OnDisable()
    {
        cubeSpawner.OnSpawningComplete -= AllCubesInLevelSpawned;
    }



    private void Update()
    {
        if (!allCubesSpawned) 
            return;

        int blueCubeCount = GameObject.FindGameObjectsWithTag("Blue Cube").Length;
        int redCubeCount = GameObject.FindGameObjectsWithTag("Red Cube").Length;

        cubeCount = blueCubeCount + redCubeCount;

        if (cubeCount <= 0) 
        {
            OnLevelComplete();
        }

    }


    void AllCubesInLevelSpawned()
    {
        allCubesSpawned = true;
    }

    void OnLevelComplete()
    {
        boxesHit.text = ("Boxes Hit: " + boxesHitText.GetComponent<Text>().text);
        boxesMissed.text = ("Boxes Missed: " + boxesMissedText.GetComponent<Text>().text);
        playerHUD.SetActive(false);
        winText.SetActive(true);
        Debug.Log("LEVEL, COMPLETED");

    }

}
