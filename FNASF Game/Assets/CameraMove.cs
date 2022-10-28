using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float turn_speed = 100f;

    public Transform player_body;

    float x_rotation = 0f;
    // Update is called once per frame
    void Update()
    {
        float mouse_x = Input.GetAxis("Mouse X") * turn_speed * Time.deltaTime;
        Debug.Log(mouse_x);
        float mouse_y = Input.GetAxis("Mouse Y") * turn_speed * Time.deltaTime;

        x_rotation -= mouse_y;
        x_rotation = Mathf.Clamp(x_rotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(x_rotation, 0f, 0f);
        player_body.Rotate(Vector3.up * mouse_x);
    }
}
