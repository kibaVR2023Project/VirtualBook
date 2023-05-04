using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killerWhale : MonoBehaviour
{
    public float speed = 10.0f; // speed of the fish movement
    public float rotationSpeed = 10.0f; // speed of the fish rotation
    public Vector3 targetPosition; // the position the fish should stop at
    private bool hasRotated = false; // flag to track if the fish has rotated



    void Update()
    {
        // move the fish forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // rotate the fish based on the horizontal input axis
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);

        // check if the fish has reached the target position
        targetPosition = new Vector3(14, 6, 6);
        if (transform.position.z >= targetPosition.z)
        {
            // stop the fish from moving
            speed = 0.0f;
            if (!hasRotated)
            {
                transform.Rotate(0.0f, 180.0f, 0.0f);
                hasRotated = true;
                speed = 9.0f;
                // move the fish forward
                transform.Translate(Vector3.forward * speed * Time.deltaTime);

                // rotate the fish based on the horizontal input axis
                transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);

            }

        }




    }
}
