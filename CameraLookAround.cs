using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CameraLookAround : MonoBehaviour
{
    // rotation
    public float mouseSensitivity = 100f;
    float xRotation = 90f;

    public Transform playerBody;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
