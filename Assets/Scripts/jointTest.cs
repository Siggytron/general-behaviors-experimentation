using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jointTest : MonoBehaviour
{
    public float thrust;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.contacts[0].point);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.forward * thrust);   
        }
    }
}
