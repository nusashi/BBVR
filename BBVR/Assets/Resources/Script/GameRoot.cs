using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRoot : MonoBehaviour
{
    public int blockNum;
    public GameObject endText;
    public GameObject clearText;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(blockNum);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(blockNum <= 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        if(Time.timeScale != 0)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1.0f;
        }

        if (blockNum <= 0)
        {
            clearText.SetActive(true);
        }
        else
        {
            endText.SetActive(true);
        }
    }
}
