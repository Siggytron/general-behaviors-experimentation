using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jointOnCollision : MonoBehaviour
{
    public float thrust;
    Rigidbody rb;
    Rigidbody otherrb;
    FixedJoint fj;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.contacts[0].point);
        print("collison.gameObject:" + collision.gameObject);
        print("this.gameObject:" + this.gameObject);

        otherrb = collision.gameObject.GetComponent<Rigidbody>();
        fj = this.gameObject.AddComponent<FixedJoint>();
        fj.connectedBody = otherrb;

        print("fj.connectedAnchor: "+ fj.connectedAnchor);
        print("fj.Anchor: "+ fj.anchor);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.forward * thrust);   
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up * thrust);
        }
    }
}
