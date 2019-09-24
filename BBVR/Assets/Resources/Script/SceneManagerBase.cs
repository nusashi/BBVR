using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerBase : MonoBehaviour
{

    static int updateLine = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (updateLine)
        {
            case 0:
                Initialize();
                updateLine++;
                break;
            case 1:
                MainLoop();
                break;
        }
    }

    public virtual void Initialize()
    {
        Debug.Log("Initialize");
    }

    public virtual void MainLoop()
    {

    }
}
