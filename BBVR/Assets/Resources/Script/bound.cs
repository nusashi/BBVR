using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bound : MonoBehaviour
{
    public enum POWER_VECTOR
    {
        NON,UP, DOWN, RIGHT, LEFT
    }

    public POWER_VECTOR powerVector;
    public float forcePower;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //public void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name == "ball")
    //    {
    //        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

    //        Debug.Log(rb.velocity.x > 0);
    //        Debug.Log(rb.velocity.z > 0);
    //        Debug.Log(rb.velocity.magnitude <= 3.0f);
    //        Debug.Log(rb.velocity);
    //        if (rb.velocity.magnitude <= 3.0f)
    //        {
    //            Vector3 force = new Vector3(-rb.velocity.x, rb.velocity.y, -rb.velocity.z) * forcePower;
    //            //switch (powerVector)
    //            //{
    //            //    case POWER_VECTOR.UP:
    //            //        force = new Vector3(-rb.velocity.x, rb.velocity.y, rb.velocity.z) * forcePower;
    //            //        break;
    //            //    case POWER_VECTOR.DOWN:
    //            //        force = new Vector3(-rb.velocity.x, rb.velocity.y, rb.velocity.z) * forcePower;
    //            //        break;
    //            //    case POWER_VECTOR.RIGHT:
    //            //        force = new Vector3(rb.velocity.x, rb.velocity.y, 1.0f) * forcePower;
    //            //        break;
    //            //    case POWER_VECTOR.LEFT:
    //            //        force = new Vector3(rb.velocity.x, rb.velocity.y, -1.0f) * forcePower;
    //            //        break;
    //            //    default:

    //            //        break;

    //            //}
    //            ////rb.AddForce(force);
    //            rb.velocity = force;
    //            if (this.gameObject.transform.parent)
    //            {
    //                if (this.gameObject.transform.parent.gameObject.tag == "block")
    //                {
    //                    Destroy(this.gameObject.transform.parent.gameObject);
    //                }
    //            }
    //        }
    //    }
    //}
}
