using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] dinoPrefabs;

    public float spawnPosX = 5;
    
    public float spawnRangeZ = 2;

    private float startDelay = 1;
    private float spawnInterval = 3;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomDino", startDelay, spawnInterval);
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    
    void SpawnRandomDino()
    {
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        int dinoIndex = Random.Range(0, dinoPrefabs.Length);
        Instantiate(dinoPrefabs[dinoIndex], spawnPos, dinoPrefabs[dinoIndex].transform.rotation);
    }
}
