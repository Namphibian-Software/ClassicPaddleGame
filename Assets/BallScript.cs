using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public AudioClip audioClipPlayer1;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<Rigidbody>().freezeRotation = true;
        //GetComponent<Rigidbody>().freezeRotation=true;
        //rigidbody.freezeRotation = true;
        //Wait(1.0f);
        GetComponent<Rigidbody>().AddForce(Random.Range(6, 8), Random.Range(-4, -3), 0);
        audioSource = GetComponent<AudioSource>();
    }
    IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().PlayOneShot(audioClipPlayer1);
    }
}
