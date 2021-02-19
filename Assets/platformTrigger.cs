using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformTrigger : MonoBehaviour
{
    public GameObject ledge;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        player.gameObject.transform.parent = ledge.transform;
        
        
    }
}
