using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockFactory : MonoBehaviour
{
    public GameObject gameRoot;
    public GameObject blockPrefab;
    public GameObject blocksObj;
    void Awake()
    {
        int LineX = 1;
        int LineZ = 1;
        int blockNum = LineX * LineZ;
        gameRoot.GetComponent<GameRoot>().blockNum = blockNum;
        for (int x = 0; x < LineX; x++)
        {
            for (int z = 0; z < LineZ; z++)
            {
                var g = Instantiate(blockPrefab, blocksObj.transform);
                Debug.Log(g);
                g.transform.position = new Vector3((-0.9f + (0.3f * x)), 0.15f, this.transform.position.z + (0.15f * z));
            }
        }
    }
}
