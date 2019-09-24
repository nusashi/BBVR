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
        Vector3 force = new Vector3(0.0f, 0.0f, -10.0f) * speed;
        // 力を加える
        rb.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
