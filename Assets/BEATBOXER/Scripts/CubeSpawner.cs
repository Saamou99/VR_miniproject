using System;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    
    public event Action<int> OnCubeSpawned = (count) => { }; 
    public event Action OnSpawningComplete = () => { };  
    
    [SerializeField] GameObject[] cubes;
    
    [SerializeField] float beatsPerMinute = 130;

    [SerializeField] private GameManager gameManager;  


    private float timer = 0f;     
    private int cubeSpawnThreshold; 
    private int cubesSpawned; 

    
    private float[,] lanePositions =
    {
        {0f, 1f, 0f },
        {-0.6f,1.25f, 0 },
        {0.6f, 1.25f, 0 },
        {-0.3f, 1f, 0 },
        {0.3f, 1f, 0 }
    };


    private void Start()
    {
        cubeSpawnThreshold = gameManager.BoxesInLevel;
    }

    private void Update()
    {
        if (cubesSpawned >= cubeSpawnThreshold) 
        {
            OnSpawningComplete(); 
            gameObject.SetActive(false); 
            return;
        }

        timer += Time.deltaTime;

        float beatInterval = (60.0f / beatsPerMinute) * 2f; 
        
        if (timer > beatInterval)
        {
            timer = 0f; 
            CreateCube();
            OnCubeSpawned(1); 
        }
    }

    void CreateCube()
    {
        if (cubes.Length == 0) return; 
        
        int randomCube = UnityEngine.Random.Range(0, cubes.Length);
        GameObject cube = Instantiate(cubes[randomCube]);

        cube.transform.position = transform.position; 

        cube.transform.Rotate(transform.forward, 90 * UnityEngine.Random.Range(0, 4)); 
        
        int lane = UnityEngine.Random.Range(0, 5);
        
        cube.transform.position += new Vector3(lanePositions[lane, 0], lanePositions[lane, 1], lanePositions[lane, 2]); 

        cubesSpawned++; 
    }

}

