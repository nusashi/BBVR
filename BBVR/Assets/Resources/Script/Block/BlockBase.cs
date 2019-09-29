using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBase : MonoBehaviour
{
    public bool isDestroyBlock;
    public enum BOUND_TYPE
    {
        VERTICAL, HORIZONTAL
    }

    public BOUND_TYPE boundType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        GameRoot gameRoot = GameObject.Find("GameRoot").GetComponent<GameRoot>();
        if (isDestroyBlock)
        {
            if (this.gameObject.transform.parent)
            {
                Destroy(this.gameObject.transform.parent.gameObject);
                gameRoot.blockNum--;
            }
        }
        if(this.gameObject.transform.parent.gameObject.name == "BottomWall")
        {
            gameRoot.GameOver();
        }
    }

    public BOUND_TYPE GetBoundType()
    {
        return boundType;
    }
}
