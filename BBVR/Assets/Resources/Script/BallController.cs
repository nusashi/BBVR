using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public float forcePower;
    // Start is called before the first frame update

    private float x;
    private float y;
    private float z;
    void Start()
    {
        // 力を設定
        x = 1.0f;
        z = 1.0f;
        //Debug.Log("x =" + x);
        //Debug.Log("y =" + y);
        //Vector3 force = new Vector3(1.0f, 0.0f, 1.0f) * forcePower;
        // 力を加える
        //rb.AddForce(force);
        //rb.AddForce(
        //    (transform.forward + transform.right) * speedX,
        //    ForceMode.VelocityChange);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 nowPosition = this.transform.position;

        //this.transform.position = new Vector3(this.transform.position.x + speedX, this.transform.position.y, this.transform.position.z + speedZ);
    }

    void FixedUpdate()
    {
        // rigidbodyを取得
        Rigidbody rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(x, 0.0f, z) * forcePower;
    }

    public void OnCollisionEnter(Collision collision)
    {
        BlockBase blockBase = collision.gameObject.GetComponent<BlockBase>();
        if (blockBase)
        {
            switch (blockBase.GetBoundType())
            {
                case BlockBase.BOUND_TYPE.VERTICAL:
                    SwitchBallVerticalVector();
                    break;
                case BlockBase.BOUND_TYPE.HORIZONTAL:
                    SwitchBallHorizontalVector();
                    break;
            }
        }
    }

    void SwitchBallVerticalVector()
    {
        x = -x;
    }
    void SwitchBallHorizontalVector()
    {
        z = -z;
    }
}
