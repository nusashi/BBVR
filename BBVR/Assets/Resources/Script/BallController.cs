using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        // rigidbodyを取得
        Rigidbody rb = this.GetComponent<Rigidbody>();
        // 力を設定
        //float x = Random.Range(1, 10);
        //float y = Random.Range(1, 10);
        //Debug.Log("x =" + x);
        //Debug.Log("y =" + y);
        Vector3 force = new Vector3(1.0f, 0.0f, 1.0f) * speed;
        // 力を加える
        rb.AddForce(force);
        //rb.AddForce(
        //    (transform.forward + transform.right) * speed,
        //    ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }
}
