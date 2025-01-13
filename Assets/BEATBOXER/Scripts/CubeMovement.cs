using UnityEngine;

//This code was inspired by, and modified to fit this project, this project: https://www.udemy.com/course/unity-virtual-reality-vr-development-a-beat-boxer-game/?couponCode=JUST4U02223

public class CubeMovement : MonoBehaviour
{
    
    [SerializeField] float cubeSpeed = 2f; 

    private Vector3 movement; 


    void Start()
    {
        movement = new Vector3(0f, 0f, cubeSpeed); 

    }

    void Update()
    {
        transform.Translate(movement * Time.deltaTime); 

    }


}
