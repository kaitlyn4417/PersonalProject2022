using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public TextMeshProUGUI titleText;
	public Button startButton;
	public TextMeshProUGUI scoreText;
	public TextMeshProUGUI gameOverText;
	public GameObject background;
	public Button restartButton;
	private int score;
	public TextMeshProUGUI descriptionText;

	private float spawnRate = 3.0f;

	public GameObject[] dinoPrefabs;

    private float spawnPosX = 18;
    
    public float spawnRangeZ = 8;

	private bool dinoSpawnX = true;

	public float speed = 1.0f;
	
	public bool rightTarget = false;

	PlayerGrowth playerGrowth;

	public int spawnNum = 8;
	private int points = 0;

	public bool isGameActive;

    // Start is called before the first frame update
    void Start()
    {
		//opens start screen
		playerGrowth = GameObject.Find("Player").GetComponent<PlayerGrowth>();
		background.gameObject.SetActive(true);
		titleText.gameObject.SetActive(true);
		startButton.gameObject.SetActive(true);
		descriptionText.gameObject.SetActive(true);
		scoreText.gameObject.SetActive(false);
		gameOverText.gameObject.SetActive(false);
		restartButton.gameObject.SetActive(false);
		startButton.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerGrowth.playerSize > points)
		{
			spawnNum++;
			points += 50;
		}
		scoreText.text = "Score: " + playerGrowth.playerSize;

    }

	//starts the game
	public void StartGame()
	{
		isGameActive = true;
		background.gameObject.SetActive(false);
		scoreText.gameObject.SetActive(true);
		titleText.gameObject.SetActive(false);
		startButton.gameObject.SetActive(false);
		descriptionText.gameObject.SetActive(false);
		StartCoroutine(dinoSpawn());
		Debug.Log("game started");
	}

	//a method to spawn dinos
	IEnumerator dinoSpawn()
	{
		while(isGameActive)
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
			Vector3 spawnPosRight = dinoCloneOne.transform.position + new Vector3(0,1,0);
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

	
	//game over :(
	public void GameOver()
	{
		isGameActive = false;
		scoreText.transform.position = new Vector3(510, 200, 0);
		background.gameObject.SetActive(true);
		gameOverText.gameObject.SetActive(true);
		restartButton.gameObject.SetActive(true);
	}
	
	//restart game method
	public void RestartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
