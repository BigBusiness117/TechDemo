using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    Vector3 myVector;
    Vector3 nextVector;
    public Transform Telport;
    public Transform TeleportBack;
    void Start()
    {


    }

    private void OnTriggerEnter(Collider other)
    {
        myVector = new Vector3(0f, 0f, 20f);
        nextVector = new Vector3(0f, 0f, -20f);
        if (other.tag == "Teleport")
        {
            gameObject.transform.position = Telport.position;
        }
        if (other.tag == "TeleportBack")
        {
            gameObject.GetComponent<CharacterController>().Move(nextVector);
        }
    }
}