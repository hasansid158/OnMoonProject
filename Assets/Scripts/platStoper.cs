using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platStoper : MonoBehaviour
{
    public Transform pl;
    public GameObject HighScoreCan;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "plat" || col.gameObject.tag == "sPlat" || col.gameObject.tag == "coinP")
        {
            col.gameObject.SetActive(false);
            HighScoreCan.SetActive(false);
        }

        if(col.gameObject.tag == "partC")
        {
            col.gameObject.SetActive(false);
        }
    }
}
