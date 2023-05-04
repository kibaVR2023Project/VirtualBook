using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyFish : MonoBehaviour
{
    public float speed = 2.0f; // Speed of movement
    public float height = 1.0f; // Height of movement
    public float frequency = 1.0f; // Frequency of movement

    private Vector3 initialPosition;

    void Start()
    {
        // Store the initial position of the shark
        initialPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new position of the shark based on the time
        float newY = Mathf.Sin(Time.time * frequency) * height;
        Vector3 newPosition = new Vector3(initialPosition.x, initialPosition.y + newY, initialPosition.z);

        // Move the shark towards the new position
        transform.position = Vector3.MoveTowards(transform.position, newPosition, speed * Time.deltaTime);

        // Rotate the shark to face the direction of movement
        transform.rotation = Quaternion.LookRotation(newPosition - transform.position);
    }
}
