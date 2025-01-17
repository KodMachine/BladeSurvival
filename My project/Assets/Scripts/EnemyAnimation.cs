using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    public  Transform sprite;
    public float speed;
    public float minSize;
    public float maxSize;

    private float activeSize;

    // Start is called before the first frame update
    void Start()
    {
        speed = speed * Random.Range(.75f, 1.25f);
        minSize = 0.9f;
        maxSize = 1.1f;
        activeSize = maxSize;
    }

    // Update is called once per frame
    void Update()
    {
        sprite.localScale = Vector3.MoveTowards(
            sprite.localScale,
            Vector3.one * activeSize,
            speed * Time.deltaTime
        );
        if(sprite.localScale.x == activeSize ) 
        {
            if(activeSize == maxSize) 
            { 
                activeSize = minSize; 
            }
            else 
            { 
                activeSize = maxSize; 
            }
        }
    }
}
