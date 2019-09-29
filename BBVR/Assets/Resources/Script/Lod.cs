using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lod : MonoBehaviour
{
    public GameObject VRCamera;
    void Update()
    {
        //カメラの座標を取ります。
        Vector3 pos = VRCamera.transform.position;
        //Barの座標が20以下（壁より内側）である場合には移動を実施します。
        if (pos.x * 2 <= 1 && pos.x * 2 >= -1)
　　　　　　{
            this.transform.position = new Vector3(pos.x * 2, this.transform.position.y, this.transform.position.z);
        }
    }
}