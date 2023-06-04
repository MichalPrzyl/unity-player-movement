using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    // movement
    public float speed;

  

    void Start()
    {
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {

        // new movement
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 movement = transform.position;
            movement += transform.forward * speed * Time.deltaTime;
            transform.position = movement;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 movement = transform.position;
            movement -= transform.forward * speed * Time.deltaTime;
            transform.position = movement;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 movement = transform.position;
            movement += transform.right * speed * Time.deltaTime;
            transform.position = movement;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 movement = transform.position;
            movement -= transform.right * speed * Time.deltaTime;
            transform.position = movement;
        }

        // old rotation
        //if (turn.y > 90 || turn.y < -90) return;
        //turn.x += Input.GetAxis("Mouse X") * mouseSensitivity;
        //turn.y += Input.GetAxis("Mouse Y") * mouseSensitivity;
        //transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);

        // new rotation
        //float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        //float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //xRotation -= mouseY;
        //xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        //transform.Rotate(Vector3.up * mouseX);

        // new rotation 2
        //mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        //mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        //xRotation -= mouseY;
        //xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //playerBody.Rotate(Vector3.up * mouseX);
    }
}
