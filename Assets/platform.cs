using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public Transform movingplatform;
    private bool moving = true;
    private Transform disPlatform;
    public Transform pos1;
    public Transform pos2;
    // Start is called before the first frame update
    void Start()
    {
        movingplatform = movingplatform.GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (movingplatform.position.x < pos2.position.x)
        {
            moving = false;
        }
        else if (movingplatform.position.x > pos1.position.x)
        {
            Debug.Log(movingplatform.position.x);
            moving = true;

        }
        if(moving == true)
        {
            movingplatform.transform.Translate(new Vector3(-3, 0, 0) * Time.deltaTime);
        }
        if(moving == false)
        {
            movingplatform.transform.Translate(new Vector3(3, 0, 0) * Time.deltaTime);

        }
    }
}
