using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float turn_speed = 200f;

    public Transform player_body;

    public float screen_size = Screen.width;
    public float left_screen_size = screen_size / 3;
    public float right_screen_size = left_screen_size + right_screen_size / 3;

    // Update is called once per frame
    void Update()
    {
        float mouse_x = Input.GetAxis("Mouse X") * turn_speed * Time.deltaTime;
        player_body.Rotate(Vector3.up * mouse_x);
    }
}
