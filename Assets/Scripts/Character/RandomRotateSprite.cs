using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomRotateSprite : MonoBehaviour
{
    public GameObject sprite;

    public float timer;

    public int flipXRNG;
    public int flipYRNG;

    public float colorRNG;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer > 0.5f)
        {
            if (transform.rotation.z > 30)
            {
                transform.Rotate(0, 0 , -30);
            }

            if (transform.rotation.z < -30)
            {
                transform.Rotate(0, 0 , 30);
            }

            transform.Rotate(0, 0 , Random.Range(20, -20));

            colorRNG = Random.Range(0, 0.1f);
            sprite.GetComponent<SpriteRenderer>().color = new Color(colorRNG, colorRNG, colorRNG, 1);
            
            flipXRNG = Random.Range(0, 2);
            if (flipXRNG == 1)
                sprite.GetComponent<SpriteRenderer>().flipX = true;
            if(flipXRNG == 0)
                sprite.GetComponent<SpriteRenderer>().flipX = false;
 
            flipYRNG = Random.Range(0, 2);
            if (flipYRNG == 1)
                sprite.GetComponent<SpriteRenderer>().flipY = true;
            if(flipYRNG == 0)
                sprite.GetComponent<SpriteRenderer>().flipY = false;

            
            
            timer = 0;
        }

    }
}
