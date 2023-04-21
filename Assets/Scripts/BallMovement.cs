using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum PlayerType
{
    PLAYER1,
    PLAYER2,
}

class OnGoalArgs : EventArgs
{
    public PlayerType player;
}

/**
 * OBSERVED
 */
public class BallMovement : MonoBehaviour
{
    public event EventHandler OnGoal;

    public Vector2 Speed = new Vector2(10f, 0f);
    private Rigidbody2D rb;
    private bool isRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Speed.x, Speed.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            rb.velocity = new Vector2(Speed.x, Speed.y);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.transform.CompareTag("Wall"))
        {
            Speed.y *= -1f;
        }
        else
        {
            Speed.y = UnityEngine.Random.Range(5f, -5f);
            Speed.x *= -1f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        OnGoalArgs args = new OnGoalArgs();

        if (rb.velocity.x > 0)
        {
            // Goal player 1
            args.player = PlayerType.PLAYER1;
        }
        else
        {
            // Golas player 2
            args.player = PlayerType.PLAYER2;
        }


        // Send event to observers
        OnGoal?.Invoke(this, args);

        transform.position = new Vector3(0f, 0f, 0f);
    }

    public void Run()
    {
        isRunning = true;
    }

    public void Stop()
    {
        isRunning = false;
    }
}
