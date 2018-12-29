using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRelaunch : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.position.x > 0)
            Scoring.scorep1++;
        else
            Scoring.scorep2++;
        other.transform.position = new Vector3(0, 0, 0);
       // other.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
       // other.GetComponent<Rigidbody>().AddForce(Random.Range(6, 8), Random.Range(-4, -3), 0);
    }
}
