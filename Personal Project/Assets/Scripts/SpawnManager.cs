using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] dinoPrefabs;

    private float spawnPosX = 18;
    
    public float spawnRangeZ = 8;

	private bool dinoSpawnX = true;

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
		//spawns dino on right side
		if (dinoSpawnX == true)
		{
        	Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
       	 	int dinoIndex = Random.Range(0, dinoPrefabs.Length);
        	var dinoCloneOne = Instantiate(dinoPrefabs[dinoIndex], spawnPos, dinoPrefabs[dinoIndex].transform.rotation);
			dinoCloneOne.gameObject.tag = "RightSpawnPoint";
			dinoSpawnX = false;
		}
		//spawns dino on left side
		else if (dinoSpawnX == false)
		{
		 	Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        	int dinoIndex = Random.Range(0, dinoPrefabs.Length);
        	var dinoCloneTwo = Instantiate(dinoPrefabs[dinoIndex], spawnPos, dinoPrefabs[dinoIndex].transform.rotation);
			dinoCloneTwo.gameObject.tag = "LeftSpawnPoint";
			dinoSpawnX = true;
		}
    }
}
