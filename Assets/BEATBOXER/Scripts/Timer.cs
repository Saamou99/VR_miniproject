using UnityEngine;
using UnityEngine.UI;

//This code was inspired by, and modified to fit this project, this project: https://www.udemy.com/course/unity-virtual-reality-vr-development-a-beat-boxer-game/?couponCode=JUST4U02223

public class Timer : MonoBehaviour
{
    
    [SerializeField] private Text timerTxt;

    private float eT; 


    void Update()
    {
        eT = Time.realtimeSinceStartup;
        DisplayTime(eT);
    }

    void DisplayTime(float timeToDisplay)
    {
        int minutes = Mathf.FloorToInt(timeToDisplay / 60f);
        int seconds = Mathf.FloorToInt(timeToDisplay % 60f);

        timerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }


}
