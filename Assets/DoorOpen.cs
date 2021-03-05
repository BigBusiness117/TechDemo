using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject Doorobject;
    public Transform Door;
    public float speed;
    private bool opened = false;
    // Start is called before the first frame update
    void Start()
    {
        speed = -1;
        Door = Door.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Block"))
        {
            

        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Block"))
        {
        if (Door.position.y <= 3.3f)
            {
                opened = true;
            }
            else if (opened == false)
            {
                Doorobject.transform.Translate(new Vector3(0, speed, 0) * Time.deltaTime);

            }


        }
        
    }
    private void OnTriggerExit(Collider other)
    {
    }    
}

