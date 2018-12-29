using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2 : MonoBehaviour
{
    private static int MOVEMENT_SPEED = 20;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            if (transform.position.y < 12)
            {
                transform.Translate(0, MOVEMENT_SPEED * Time.deltaTime, 0);
            }

        }
        if (Input.GetKey("down"))
        {
            if (transform.position.y > -12)
            {
                transform.Translate(0, -MOVEMENT_SPEED * Time.deltaTime, 0);
            }
        }
    }
}
