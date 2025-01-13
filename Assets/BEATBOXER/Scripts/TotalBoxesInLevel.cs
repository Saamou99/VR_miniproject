using UnityEngine;
using UnityEngine.UI;

//This code was inspired by, and modified to fit this project, this project: https://www.udemy.com/course/unity-virtual-reality-vr-development-a-beat-boxer-game/?couponCode=JUST4U02223

public class TotalBoxesInLevel : MonoBehaviour
{

    [SerializeField] private Text boxesInLevel; 
    [SerializeField] private Image fillBar; 

    [SerializeField] private GameManager gameManager ; 
    [SerializeField] private CubeSpawner cubeSpawner; 

    private float totalBoxCount; 
    private float boxesSpawned; 

    private void Start()
    {
        
        totalBoxCount = gameManager.BoxesInLevel;
        boxesInLevel.text = totalBoxCount.ToString(); 
        fillBar.fillAmount = 1.0f; 
    }

    private void OnEnable()
    {
        cubeSpawner.OnCubeSpawned += UpdateUIData;
    }

    private void OnDisable()
    {
        cubeSpawner.OnCubeSpawned -= UpdateUIData;
    }

    void UpdateUIData(int boxCount)
    {
        boxesSpawned += boxCount;

        
        boxesInLevel.text = (totalBoxCount - boxesSpawned).ToString();
        fillBar.fillAmount = 1.0f -  (boxesSpawned / totalBoxCount);


        //Debug.Log($"Fill Bar Fill Amount : { fillBar.fillAmount}");

    }

}
