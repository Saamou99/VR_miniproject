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

        GetComponent<AudioSource>().Play(); 

        OnCubeHit(1); 
        
        Debug.Log("On Cube HIT!");

        Destroy(other.gameObject.GetComponentInParent<Rigidbody>().gameObject); 

        Debug.Log("Destroyed!");
    }
    
    
}
