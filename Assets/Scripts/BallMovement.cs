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
        // Access to the position of the Game Object (the ball)
        // Vector3 position = transform.position;

        // Vector3 newPosition = new Vector3(
        //     position.x + (Speed * Time.deltaTime),
        //     position.y,
        //     position.z
        // );

        // transform.position = newPosition;

        // Vector3.right is what is below
        // Vector3 unitRight = new Vector3(1f, 0f, 0f);

        // This does the same of all what is above
        // transform.position += Vector3.right * Speed * Time.deltaTime;
        // Can't use this because Speed changed to Vector
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        Speed *= -1f;
    }
}
