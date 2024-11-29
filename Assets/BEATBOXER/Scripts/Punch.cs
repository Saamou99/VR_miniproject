using System;
using UnityEngine;



//This script must be attached to each glove. 

public class Punch : MonoBehaviour
{
    //Events
    public event Action<int> OnCubeHit = (count) => { }; //This event  is being listened for in the 'BoxesHit' script. Whenever a cube/box is hit, this event is raised in this script. 
    public event Action<string> OnCubeHitHaptics = (hand) => { }; //This event is being listend for in the 'GenerateHapticFeedback' script.   


    [SerializeField] LayerMask layer; //maps to the cubes layer, ensuring that a Red cub is hit with a Red Glove only and a Blue Cube is hit with a blue glove only.
    
    private Vector3 previousPosn = Vector3.zero; //keeps track of the gloves previous position. Used only for the purpose of creating a directional Vector, that is required by the Vector3.Angle() method used below.

    private string interactor; //Useful in determining whether the Punch was thrown by the Left or Right controller/Interactor/Hand.


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
