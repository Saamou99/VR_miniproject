using System;
using UnityEngine;
using UnityEngine.XR;


public class Punch : MonoBehaviour
{
    //Events
    public event Action<int> OnCubeHit = (count) => { }; 
    
    //[SerializeField] LayerMask layer; 
    
    private Vector3 previousPosn = Vector3.zero; 

    private string interactor; 


    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the current game object has the "Red Glove" or "Blue Glove" tag
        if (gameObject.CompareTag("Red Glove") && other.CompareTag("Red Cube"))
        {
            HandleHit(other);
        }
        else if (gameObject.CompareTag("Blue Glove") && other.CompareTag("Blue Cube"))
        {
            HandleHit(other);
        }

    }

    private void HandleHit(Collider other)
    {
        Debug.Log("HIT!");

        GetComponent<AudioSource>().Play(); // Play the Punch sound when the cube is hit correctly.

        OnCubeHit(1); // Raise event to notify 'BoxesHit' that 1 cube has been hit correctly.
        
        Debug.Log("On Cube HIT!");

        Destroy(other.gameObject.GetComponentInParent<Rigidbody>().gameObject); // Destroy the cube as it was punched correctly.

        Debug.Log("Destroyed!");
    }
    
    
}
