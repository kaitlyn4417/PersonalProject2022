using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrowth : MonoBehaviour
{
    public float points;
	public int playerSize = 5;
    public float scale = 2;
	

	//public int foodPoints = (GameObject.FindGameObjectsWithTag("RightSpawnPoint") || GameObject.FindGameObjectsWithTag("LeftSpawnPoint")).GetComponent.dinoSize;
	
	//MoveHorizontally moveHorizontally;

    // Start is called before the first frame update
    void Start()
    {
        //spawnManager = SpawnManager.GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
		//int dinoOne = spawnManager.dinoPrefabs[0];
		
		
        if (points > 100)
        {
            transform.localScale = new Vector3(scale, scale, scale);
        }
    }

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "RightSpawnPoint" || other.gameObject.tag == "LeftSpawnPoint")
		{
			Destroy(other.gameObject);
		}
		playerSize = playerSize + foodPoints;
		Debug.Log(playerSize);
	}
}
