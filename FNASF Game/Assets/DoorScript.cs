using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public float door_speed;

    public GameObject left_door;
    public GameObject front_door;

    public LayerMask front_door_button;
    public LayerMask left_door_button;

    public bool is_front_door_shut;
    public bool is_left_door_shut;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            RaycastHit door_shut;
            Ray door_control = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(door_control, out door_shut, front_door_button) && door_shut.transform.gameObject.layer == 6 && is_front_door_shut == false){
                StartCoroutine(ShutFrontDoor());
            } else if(Physics.Raycast(door_control, out door_shut, front_door_button) && door_shut.transform.gameObject.layer == 6 && is_front_door_shut == true){
                StartCoroutine(OpenFrontDoor());
            } else if(Physics.Raycast(door_control, out door_shut, left_door_button) && door_shut.transform.gameObject.layer == 7 && is_left_door_shut == false){
                StartCoroutine(ShutLeftDoor());
            } else if(Physics.Raycast(door_control, out door_shut, left_door_button) && door_shut.transform.gameObject.layer == 7 && is_left_door_shut == true){
                StartCoroutine(OpenLeftDoor());
            }
        }
    }
    

    IEnumerator ShutFrontDoor()
    {
        while(front_door.transform.position.y > 2f){
            Vector3 door_shut_next_position = new Vector3(0f, door_speed * Time.deltaTime, 0f);
            front_door.transform.position -= door_shut_next_position;
            yield return null;
        }
        is_front_door_shut = true;
    }

    IEnumerator ShutLeftDoor()
    {
        while(left_door.transform.position.y > 2f){
            Vector3 door_shut_next_position = new Vector3(0f, door_speed * Time.deltaTime, 0f);
            left_door.transform.position -= door_shut_next_position;
            yield return null;
        }
        is_left_door_shut = true;
    }

    IEnumerator OpenFrontDoor(){
        while(front_door.transform.position.y < 4f){
            Vector3 door_shut_next_position = new Vector3(0f, door_speed * Time.deltaTime, 0f);
            front_door.transform.position += door_shut_next_position;
            yield return null;
        }
        is_front_door_shut = false;
    }

    IEnumerator OpenLeftDoor(){
        while(left_door.transform.position.y < 4f){
            Vector3 door_shut_next_position = new Vector3(0f, door_speed * Time.deltaTime, 0f);
            left_door.transform.position += door_shut_next_position;
            yield return null;
        }
        is_left_door_shut = false;
    }
}
