using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    // public float speed = 3f;
    // // Start is called before the first frame update
    // void Start()
    // {

    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     if (Input.GetMouseButton(0)) {
    //         transform.RotateAround(transform.position, -Vector3.up, Input.GetAxis("Mouse X"));
    //         transform.RotateAround(transform.position, Vector3.right, speed * Input.GetAxis("Mouse Y"));

    //     }
    // }

    public float rotationSpeed = 3f;

    float pitch;
    float yaw;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            pitch += rotationSpeed * Input.GetAxis("Mouse Y");
            yaw += rotationSpeed * Input.GetAxis("Mouse X");

            // Clamp pitch:
            pitch = Mathf.Clamp(pitch, -90f, 90f);
            // Debug.Log(yaw);

            // Wrap yaw:
            while (yaw < 0f)
            {
                yaw += 360f;
            }
            while (yaw >= 360f)
            {
                yaw -= 360f;
            }
            // Debug.Log(yaw);

            // Set orientation:
            transform.eulerAngles = new Vector3(pitch, yaw, 0f);
        }

    }
}
