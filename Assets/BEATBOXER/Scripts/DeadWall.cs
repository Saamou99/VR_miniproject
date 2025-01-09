using System;
using UnityEngine;

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
