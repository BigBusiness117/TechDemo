using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disable : MonoBehaviour
{
    public GameObject CheckPointObject;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            gameObject.GetComponent<Renderer>().enabled = false;
            CheckPointObject.SetActive(true);
            Invoke("DisableText", 2.0f);
            gameObject.SetActive(false);
        }

    }
    public void DisableText()
    {
        CheckPointObject.SetActive(false);


    }
}