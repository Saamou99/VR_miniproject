using System;
using UnityEngine;

//This code was inspired by, and modified to fit this project, this project: https://www.udemy.com/course/unity-virtual-reality-vr-development-a-beat-boxer-game/?couponCode=JUST4U02223


public class DeadWall : MonoBehaviour
{
    
    public event Action<int> OnCubeMissed = (count) => { }; 


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Cube : {other.gameObject.name} collided with Dead Wall");

        OnCubeMissed(1); 

        Destroy(other.gameObject.GetComponentInParent<Rigidbody>().gameObject); 

        
    }
}
