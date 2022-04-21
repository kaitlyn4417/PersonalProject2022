using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	//public List<GameObject> dinoPrefabs;
	//public SpawnManager spawnManager;

	//private float startDelay = 1;
    //private float spawnInterval = 3;
	private float spawnRate = 3.0f;

	public GameObject[] dinoPrefabs;

    private float spawnPosX = 18;
    
    public float spawnRangeZ = 8;

	private bool dinoSpawnX = true;

	
	PlayerGrowth playerGrowth;

	public int spawnNum = 8;
	public int points = 25;

    // Start is called before the first frame update
    void Start()
    {
        playerGrowth = GameObject.Find("Player").GetComponent<PlayerGrowth>();
		StartCoroutine(dinoSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        if (playerGrowth.playerSize > points)
		{
			spawnNum++;
			points += 100;
		}
    }

	IEnumerator dinoSpawn()
	{
		while(true)
		{	
			yield return new WaitForSeconds(spawnRate);
			SpawnRandomDino();
		}
	}

	public void SpawnRandomDino()
    {
		//spawns dino on left side
		if (dinoSpawnX == true)
		{
        	Vector3 spawnPos = new Vector3(spawnPosX, 0.2f, Random.Range(-spawnRangeZ, spawnRangeZ));
       	 	int dinoIndex = Random.Range(0, spawnNum);
        	var dinoCloneOne = Instantiate(dinoPrefabs[dinoIndex], spawnPos, dinoPrefabs[dinoIndex].transform.rotation);
			dinoCloneOne.gameObject.tag = "RightSpawnPoint";
			dinoSpawnX = false;
		}
		//spawns dino on right side
		else if (dinoSpawnX == false)
		{
		 	Vector3 spawnPos = new Vector3(-spawnPosX, 0.2f, Random.Range(-spawnRangeZ, spawnRangeZ));
        	int dinoIndex = Random.Range(0, spawnNum);
        	var dinoCloneTwo = Instantiate(dinoPrefabs[dinoIndex], spawnPos, dinoPrefabs[dinoIndex].transform.rotation);
			dinoCloneTwo.gameObject.tag = "LeftSpawnPoint";
			dinoSpawnX = true;
		}
    }
}
