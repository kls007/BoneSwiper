using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMove : MonoBehaviour
{
    public Rigidbody2D rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.localPosition;
        if (pos.x < -200)
        {
            rb.velocity = new Vector2(Mathf.Abs(rb.velocity.x), rb.velocity.y);
        }
        else if(pos.x > 200)
        {
            rb.velocity = new Vector2(-Mathf.Abs(rb.velocity.x), rb.velocity.y);
        }

        if (pos.y < -200)
        {
            rb.velocity = new Vector2(rb.velocity.x, Mathf.Abs(rb.velocity.y));
        }
        else if (pos.y > 200)
        {
            rb.velocity = new Vector2(rb.velocity.x, -Mathf.Abs(rb.velocity.y));
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision);
        //foreach (ContactPoint contact in collision.contacts)
        //{
        //    Debug.DrawRay(contact.point, contact.normal, Color.white);
        //}
        //if (collision.relativeVelocity.magnitude > 2)
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        //// Change the cube color to green.
        //MeshRenderer meshRend = GetComponent<MeshRenderer>();
        //meshRend.material.color = Color.green;
        //Debug.Log(other.name);
    }
    


}
