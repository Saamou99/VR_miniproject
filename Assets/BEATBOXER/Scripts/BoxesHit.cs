using UnityEngine;
using UnityEngine.UI;

public class BoxesHit : MonoBehaviour
{

    [SerializeField] private Text hitsScored; 
    [SerializeField] private Image fillBar; 
    [SerializeField] private GameManager gameManager; 
    [SerializeField] private Punch leftPunch; 
    [SerializeField] private Punch rightPunch; 


    private float totalBoxCount; 
    private float hitsCount; 

    private void Start()
    {
        
        hitsScored.text = hitsCount.ToString(); 
        fillBar.fillAmount = 0f; 
        totalBoxCount = gameManager.BoxesInLevel;
    }

    private void OnEnable()
    {
        leftPunch.OnCubeHit += UpdateUIData;
        rightPunch.OnCubeHit += UpdateUIData;

    }

    private void OnDisable()
    {
        leftPunch.OnCubeHit -= UpdateUIData;
        rightPunch.OnCubeHit -= UpdateUIData;

    }

    void UpdateUIData(int hit)
    {
        hitsCount += hit;
        
        hitsScored.text = hitsCount.ToString();
        fillBar.fillAmount = hitsCount / totalBoxCount ;


        //Debug.Log($"Fill Bar Fill Amount : { fillBar.fillAmount}");

    }
}
