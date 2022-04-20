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


	PlayerGrowth playerGrowth;

	public int spawnNum = 5;
	public int points = 25;

    void Start()
    {
		playerGrowth = GameObject.Find("Player").GetComponent<PlayerGrowth>();
        InvokeRepeating("SpawnRandomDino", startDelay, spawnInterval);
        
    }

    // Update is called once per frame
    void Update()
    {
		//spawns new dinos as player grows
		if (playerGrowth.playerSize > points)
		{
			spawnNum++;
			points += 100;
		}
    }
    
    
    void SpawnRandomDino()
    {
		//spawns dino on left side
		if (dinoSpawnX == true)
		{
        	Vector3 spawnPos = new Vector3(spawnPosX, 0.2f, Random.Range(-spawnRangeZ, spawnRangeZ));
       	 	int dinoIndex = Random.Range(0, 2);
        	var dinoCloneOne = Instantiate(dinoPrefabs[dinoIndex], spawnPos, dinoPrefabs[dinoIndex].transform.rotation);
			dinoCloneOne.gameObject.tag = "RightSpawnPoint";
			dinoSpawnX = false;
		}
		//spawns dino on right side
		else if (dinoSpawnX == false)
		{
		 	Vector3 spawnPos = new Vector3(-spawnPosX, 0.2f, Random.Range(-spawnRangeZ, spawnRangeZ));
        	int dinoIndex = Random.Range(0, 2);
        	var dinoCloneTwo = Instantiate(dinoPrefabs[dinoIndex], spawnPos, dinoPrefabs[dinoIndex].transform.rotation);
			dinoCloneTwo.gameObject.tag = "LeftSpawnPoint";
			dinoSpawnX = true;
		}
    }
}
