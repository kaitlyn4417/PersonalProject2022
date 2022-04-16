using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontally : MonoBehaviour
{
    public float speed = 1.0f;

    private float xBound = 20;
	
	public int dinoSize;
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
			transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
			//transform.rotation = new Vector3(transform.rotation.x, 180, transform.rotation.z);
		}
		else if (gameObject.CompareTag("LeftSpawnPoint"))
		{
			transform.Translate(Vector3.right * Time.deltaTime * speed);
			transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
			//transform.rotation = new Vector3(transform.rotation.x, 180, transform.rotation.z);
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
