using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontDoor : MonoBehaviour
{   
    public float door_speed;

    void ShutDoor()
    {
        Vector3 door_shut_next_position = new Vector3(0f, door_speed * Time.deltaTime, 0f);
        
    }
}
