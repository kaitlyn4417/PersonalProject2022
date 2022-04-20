using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontally : MonoBehaviour
{
    public float speed = 1.0f;

    private float xBound = 20;
	
	public float dinoScale;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(gameObject.CompareTag("RightSpawnPoint"))
		{
			transform.Translate(Vector3.left * Time.deltaTime * speed);
			transform.localScale = new Vector3(dinoScale, transform.localScale.y, transform.localScale.z);
		}
		
		if (gameObject.CompareTag("LeftSpawnPoint"))
		{
			transform.localScale = new Vector3(-dinoScale, transform.localScale.y, transform.localScale.z);
			transform.Translate(Vector3.right * Time.deltaTime * speed);
			
		}
        
        //destroys dino object if out of bounds
        if (transform.position.x < -xBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > xBound)
        {
            Destroy(gameObject);
        }
    }   
}
