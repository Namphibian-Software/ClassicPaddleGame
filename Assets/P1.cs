using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1 : MonoBehaviour
{
    // Start is called before the first frame update
    private static int MOVEMENT_SPEED = 20;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            if(transform.position.y<12)
            {
                transform.Translate(0, MOVEMENT_SPEED * Time.deltaTime, 0);
            }
            
        }
        if (Input.GetKey("s"))
        {
            if (transform.position.y > -12)
            {
                transform.Translate(0, -MOVEMENT_SPEED * Time.deltaTime, 0);
            }
        }
    }
}
