using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Rigidbody2D rBody;
    public float moveSpeed;
    private Transform target;

    public float damage;
    public float hitWaitTime;
    private float hitCounter;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        moveSpeed = 1;
        target = FindObjectOfType<PlayerController>().transform;
        damage = 5;
        hitWaitTime = 1f;
        hitCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //done in fixed update
        rBody.velocity = (target.position - transform.position).normalized * moveSpeed;

        if(hitCounter > 0f)
        {
            hitCounter -= Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && hitCounter <= 0f) 
        {
            PlayerHealthController.instance.TakeDamage(damage);

            hitCounter = hitWaitTime;
        }
    }
}
