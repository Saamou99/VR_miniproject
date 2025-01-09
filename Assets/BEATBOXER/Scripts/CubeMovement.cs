using UnityEngine;



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
