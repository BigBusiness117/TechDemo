using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPush : MonoBehaviour
{
    public Text buttonText;
    public GameObject gameButton;
    private int buttonDown;
    public Transform myTransform;
    private Vector3 posOffset;
    private int count;
    private bool buttonPushDown = false;
    private GameObject Block;
    public GameObject DoorTigger;
    // Start is called before the first frame update
    void Start()
    {
        posOffset = new Vector3(0, -2, 0);
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonPushDown == true)
        {
            myTransform.transform.Translate(0, -1, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            buttonText.enabled = true;
        }
        
    
    }
    private void OnTriggerExit(Collider other)
    {
        buttonText.enabled = false;
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Block = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Block.transform.position = new  Vector3(13, 21, -45);
            Block.AddComponent<Rigidbody>();
            Block.tag = "Block";
            Block.GetComponent<Rigidbody>().freezeRotation = true;
            Block.GetComponent<Rigidbody>().mass = 0.3f;
            Block.GetComponent<MeshRenderer>().enabled = true;
            Block.GetComponent<MeshRenderer>().material.SetColor("_Color", Random.ColorHSV());
            DoorTigger.GetComponent<MeshRenderer>().enabled = true;

        }
    }
}
