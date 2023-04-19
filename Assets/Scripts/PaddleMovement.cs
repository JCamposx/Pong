using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float Speed = 7f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Gets values in range [-1, 1], where -1 is going down and 1 is going up
        float verticalMovement = Input.GetAxis("Vertical");

        transform.position = new Vector3(
            transform.position.x,
            Mathf.Clamp( // Evaluates that a value is in a specific limit
                // What is going to be evaluated
                transform.position.y + verticalMovement * Speed * Time.deltaTime,
                // Limit inf
                -4f,
                // Limit sup
                4f
            ),
            transform.position.z
        );

        transform.position += Vector3.up * verticalMovement * Speed * Time.deltaTime;
    }
}
