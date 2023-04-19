using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float Speed = 1f;

    // Start is called before the first frame update
    void Start()
    {

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
        transform.position += Vector3.right * Speed * Time.deltaTime;
    }
}
