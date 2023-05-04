using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {



    //vitesse de roation de la souris
    private float rotateSpeed = 300.0f;

    //zoom in/out variables
    public float zoomSpeed = 600.0f;
    public float zoomAmount = 0.0f;
    public float movementSpeed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //rotation de la camera selon la souris
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x + Input.GetAxis("Mouse Y") * Time.deltaTime * rotateSpeed, transform.localEulerAngles.y + Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed, 0);
        }

        // Handle Movements
        // Forward
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }
        // Backward
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-1 * Vector3.forward * movementSpeed * Time.deltaTime);
        }
        // Left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1 * Vector3.right * movementSpeed * Time.deltaTime);
        }
        // Right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }
    }
}
