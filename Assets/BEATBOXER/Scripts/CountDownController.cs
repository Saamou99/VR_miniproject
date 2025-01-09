using System.Collections;
using UnityEngine;

public class CountDownController : MonoBehaviour
{
    
    [SerializeField] GameObject[] countDownObject;
    [SerializeField] GameObject cubeSpawner; 
    [SerializeField] GameObject playerHUD;  

    private int countDown = 3; 

    void Start()
    {
        StartCoroutine(CountDown());
    }

  
    IEnumerator CountDown()
    {
        while (countDown >= 0)
        {
            countDownObject[countDown].SetActive(true);

            yield return new WaitForSeconds(1f);

            countDownObject[countDown].SetActive(false);

            countDown--;
        }

        AudioSource audioSource = GetComponent<AudioSource>();
        
        audioSource.Play();

        playerHUD.SetActive(true); 

        cubeSpawner.SetActive(true); 

    }

}
