using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int scorefinal = 0;
    Text txt;
    void Start()
    {
        txt = GetComponent<Text>();
    }

    void Update()
    {
        PrintScore();
    }

    public void AddToScoreVOID()
    {
        scorefinal++;
        PrintScore();

    }

    public void PrintScore()
    {
        txt.text=""+ scorefinal;
    }
}
