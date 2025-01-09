using UnityEngine;
using UnityEngine.UI;


public class BoxesMissed : MonoBehaviour
{

    [SerializeField] private Text hitsMissed; 
    [SerializeField] private Image fillBar; 
    [SerializeField] private GameManager gameManager; 
    [SerializeField] private DeadWall deadWall; 
  
    private float totalBoxCount; 
    private float missedhits; 

    private void Start()
    {
        hitsMissed.text = missedhits.ToString(); 
        fillBar.fillAmount = 0f; 
        totalBoxCount = gameManager.BoxesInLevel;
    }

    private void OnEnable()
    {
        deadWall.OnCubeMissed += UpdateUIData; 
    }

    private void OnDisable()
    {
        deadWall.OnCubeMissed -= UpdateUIData;
    }




    void UpdateUIData(int missed)
    {
        missedhits += missed;

        
        hitsMissed.text = missedhits.ToString();
        fillBar.fillAmount = missedhits / totalBoxCount ;


        //Debug.Log($"Fill Bar Fill Amount : { fillBar.fillAmount}");

    }
}
