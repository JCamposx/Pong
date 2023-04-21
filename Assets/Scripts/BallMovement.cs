using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Vector2 Speed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Speed.x, Speed.y);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Speed.x, Speed.y);
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.transform.CompareTag("Wall"))
        {
            Speed.y *= -1f;
        }
        else
        {
            Speed.y = Random.Range(5f, -5f);
            Speed.x *= -1f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        transform.position = new Vector3(0f, 0f, 0f);
    }
}
