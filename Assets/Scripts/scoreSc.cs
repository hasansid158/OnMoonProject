using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreSc : MonoBehaviour
{
    public GameObject pl;
    public GameObject scoreTxt, highScoreCan, highScoreTxt;
    public float score, scoreTmp;

    void Start()
    {
        highScoreTxt.GetComponent<Text>().text =  PlayerPrefs.GetFloat("highScore").ToString("F1") + " Highest";
    }

    void Update()
    {
        transform.position = new Vector3(pl.transform.position.x + 0.04f, pl.transform.position.y + 1.1f, -2f);
        scoreTmp = pl.transform.position.x + 1.28f;
        if(scoreTmp > score)
        {
            score = scoreTmp;
            scoreTxt.GetComponent<Text>().text = score.ToString("F1");
        }
    }

    public void ScoreUpdaterNReset()
    {
        score = 0;
        scoreTmp = 0;
        if (PlayerPrefs.GetFloat("highScore") < score)
        {
            PlayerPrefs.SetFloat("highScore", score);
        }
        highScoreTxt.GetComponent<Text>().text = PlayerPrefs.GetFloat("highScore").ToString("F1") + " Highest";
    }
}
