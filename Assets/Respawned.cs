using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Respawned : MonoBehaviour
{

    public GameObject respawn;
    public GameObject player;
    Vector3 respawnPosition;
    private CharacterController controller;
    Vector3 myVector;
    Vector3 nextVector;

    private void OnTriggerEnter(Collider other)
    {
        myVector = new Vector3(0f, 0f, 20f);
        nextVector = new Vector3(0f, 0f, -20f);
        controller = player.GetComponent<CharacterController>();
        if (other.tag == "CheckPoint")
        {
           
            respawnPosition = gameObject.transform.position;
        }
       
        else if (other.tag == "KillBox")
        {
            player.transform.position = respawnPosition;
            controller.enabled = false;
            controller.enabled = true;
        }
        if (other.tag == "Teleport")
        {
           // controller.enabled = false;
            gameObject.GetComponent<CharacterController>().Move(myVector);
           // controller.enabled = true;
        }
        if (other.tag == "TeleportBack")
        {
            //controller.enabled = false;
            gameObject.GetComponent<CharacterController>().Move(nextVector);
           // controller.enabled = true;

        }
    }
}

