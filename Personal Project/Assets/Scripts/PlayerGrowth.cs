using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrowth : MonoBehaviour
{
    public float points;

    public float scale = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (points > 100)
        {
            transform.localScale = new Vector3(scale, scale, scale);
        }
    }
}
