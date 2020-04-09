using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;
    public float turnspeed;
    public float horizontalinput;
    public float forwardinput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        forwardinput = Input.GetAxis("Vertical");
        // Move the vehicle forward
        transform.Translate(Vector3.forward*Time.deltaTime*speed* forwardinput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed* horizontalinput);
    }
}
