using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrowth : MonoBehaviour
{
    public float points;
	public int playerSize = 0;
    private float scale = 0.002f;
	private float startingSize = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
	//player continuously grows in size as it "eats" other dinos
		float scaleSize = startingSize + (playerSize * scale);

		transform.localScale = new Vector3(scaleSize, scaleSize, scaleSize);
	}

	//player collides with other dinos
	 void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "RightSpawnPoint" || other.gameObject.tag == "LeftSpawnPoint")
		{
			//dinos give certain points based on their gameobject
			switch(other.gameObject.name)
			{
				case "Dino1(Clone)":
					playerSize = playerSize + 1;
					break;

				case "Dino2(Clone)":
					playerSize = playerSize + 2;
					break;

				case "Dino3(Clone)":
					playerSize = playerSize + 2;
					break;
		
				case "Dino4(Clone)":
					playerSize = playerSize + 5;
					break;

				case "Dino5(Clone)":
					playerSize = playerSize + 5;
					break;

				case "Dino6(Clone)":
					playerSize = playerSize + 7;
					break;

				case "Dino7(Clone)":
					playerSize = playerSize + 8;
					break;

				case "Dino8(Clone)":
					playerSize = playerSize + 10;
					break;

				case "Dino9(Clone)":
					playerSize = playerSize + 10;
					break;

				case "Dino10(Clone)":
					playerSize = playerSize + 10;
					break;

				case "Dino11(Clone)":
					playerSize = playerSize + 12;
					break;

				case "Dino12(Clone)":
					playerSize = playerSize + 12;
					break;

				case "Dino13(Clone)":
					playerSize = playerSize + 15;
					break;
		
				case "Dino14(Clone)":
					playerSize = playerSize + 15;
					break;

				case "Dino15(Clone)":
					playerSize = playerSize + 18;
					break;

				case "Dino16(Clone)":
					playerSize = playerSize + 18;
					break;

				case "Dino17(Clone)":
					playerSize = playerSize + 20;
					break;

				case "Dino18(Clone)":
					playerSize = playerSize + 25;
					break;

				case "Dino19(Clone)":
					playerSize = playerSize + 30;
					break;

				case "Dino20(Clone)":
					playerSize = playerSize + 35;
					break;
					
				default:
					break;
				}
			
			Destroy(other.gameObject);
		}
		Debug.Log(playerSize);
	 }
}
