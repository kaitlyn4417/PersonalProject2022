using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrowth : MonoBehaviour
{
	public int playerSize = 0;
    private float scale = 0.001f;
	private float startingSize = 0.3f;
	public PlayerController playerController;
	public GameManager gameManager;
	

    // Start is called before the first frame update
    void Start()
    {
		playerController = GameObject.Find("Player").GetComponent<PlayerController>();
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
	//player continuously grows in size as it "eats" other dinos
		float scaleSize = startingSize + (playerSize * scale);

		//flips player character in the direction it is moving
		if(playerController.facingRight == true)
		{
			transform.localScale = new Vector3(scaleSize, scaleSize, scaleSize);	
		}
		else if(playerController.facingRight == false)
		{
			transform.localScale = new Vector3(-scaleSize, scaleSize, scaleSize);
		}	
				 
	}


void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "RightSpawnPoint" || other.gameObject.tag == "LeftSpawnPoint" && gameManager.isGameActive)
		{
			//dinos give certain points based on their gameobject
			//player will 'eat' the dino as long as it is bigger than the npc dino
		switch(other.gameObject.name)
			{
				case "Dino1(Clone)":
					if (playerSize >= 0)
					{
						playerSize = playerSize + 3;
						Debug.Log("dino eaten");
					}
					else if (playerSize < 0)
					{		
						gameManager.GameOver();
					}
					break;

				case "Dino2(Clone)":
					if (playerSize >= 0)
					{
						playerSize = playerSize + 4;
					}
					else if (playerSize < 0)
					{		
						gameManager.GameOver();
					}
					break;

				case "Dino3(Clone)":
					if (playerSize >= 50)
					{
						playerSize = playerSize + 4;
					}
					else if (playerSize < 50)
					{		
						gameManager.GameOver();
					}
					break;
		
				case "Dino4(Clone)":
					if (playerSize >= 0)
					{
						playerSize = playerSize + 5;
					}
					else if (playerSize < 0)
					{		
						gameManager.GameOver();
					}
					break;

				case "Dino5(Clone)":
					if (playerSize >= 75)
					{
						playerSize = playerSize + 5;
					}
					else if (playerSize < 75)
					{		
						gameManager.GameOver();
					}
					break;

				case "Dino6(Clone)":
					if (playerSize >= 100)
					{
						playerSize = playerSize + 7;
					}
					else if (playerSize < 100)
					{		
						gameManager.GameOver();
					}
					break;

				case "Dino7(Clone)":
					if (playerSize >= 125)
					{
						playerSize = playerSize + 8;
					}
					else if (playerSize < 125)
					{		
						gameManager.GameOver();
					}
					break;

				case "Dino8(Clone)":
					if (playerSize >= 175)
					{
						playerSize = playerSize + 10;
					}
					else if (playerSize < 175)
					{		
						gameManager.GameOver();
					}
					break;

				case "Dino9(Clone)":
					if (playerSize >= 250)
					{
						playerSize = playerSize + 10;
					}
					else if (playerSize < 250)
					{		
						gameManager.GameOver();
					}
					break;

				case "Dino10(Clone)":
					if (playerSize >= 375)
					{
						playerSize = playerSize + 10;
					}
					else if (playerSize < 375)
					{		
						gameManager.GameOver();
					}
					break;

				case "Dino11(Clone)":
					if (playerSize >= 500)
					{
						playerSize = playerSize + 12;
					}
					else if (playerSize < 500)
					{		
						gameManager.GameOver();
					}
					break;

				case "Dino12(Clone)":
					if (playerSize >= 650)
					{
						playerSize = playerSize + 12;
					}
					else if (playerSize < 650)
					{		
						gameManager.GameOver();
					}
					break;

				case "Dino13(Clone)":
					if (playerSize >= 800)
					{
						playerSize = playerSize + 15;
					}
					else if (playerSize < 800)
					{		
						gameManager.GameOver();
					}
					break;
		
				case "Dino14(Clone)":
					if (playerSize >= 900)
					{
						playerSize = playerSize + 15;
					}
					else if (playerSize < 900)
					{		
						gameManager.GameOver();
					}
					break;

				case "Dino15(Clone)":
					if (playerSize >= 1000)
					{
						playerSize = playerSize + 18;
					}
					else if (playerSize < 1000)
					{		
						gameManager.GameOver();
					}
					break;

				case "Dino16(Clone)":
					if (playerSize >= 1200)
					{
						playerSize = playerSize + 18;
					}
					else if (playerSize < 1200)
					{		
						gameManager.GameOver();
					}
					break;

				case "Dino17(Clone)":
					if (playerSize >= 1500)
					{
						playerSize = playerSize + 20;
					}
					else if (playerSize < 1500)
					{		
						gameManager.GameOver();
					}
					break;

				case "Dino18(Clone)":
					if (playerSize >= 1800)
					{
						playerSize = playerSize + 25;
					}
					else if (playerSize < 1800)
					{		
						gameManager.GameOver();
					}
					break;

				case "Dino19(Clone)":
					if (playerSize >= 2100)
					{
						playerSize = playerSize + 30;
					}
					else if (playerSize < 2100)
					{		
						gameManager.GameOver();
					}
					break;

				case "Dino20(Clone)":
					if (playerSize >= 2500)
					{
						playerSize = playerSize + 35;
					}
					else if (playerSize < 2500)
					{		
						gameManager.GameOver();
					}
					break;
					
				default:
					break;
				}
			
			Destroy(other.gameObject);
			}
	}
}

	 
