using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float turn_speed = 50f;

    public Transform player_body;

    public float screen_size = Screen.width;
    public float left_screen_size;
    public float right_screen_size;

    void Start() {
        left_screen_size = screen_size / 3;
        right_screen_size = left_screen_size * 2 + screen_size / 3;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse_pos = Input.mousePosition;
        if(mouse_pos.x <= left_screen_size){
            player_body.Rotate(Vector3.up * (-Time.deltaTime * turn_speed));
        } else if(mouse_pos.x >= right_screen_size){
            player_body.Rotate(Vector3.up * (Time.deltaTime * turn_speed));
        } else {
            player_body.Rotate(Vector3.up * 0);
        }
    }
}
