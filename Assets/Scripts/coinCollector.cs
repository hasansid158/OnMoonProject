using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinCollector : MonoBehaviour
{
    public GameObject coinScoreText;
    public ObjectPools objectPoolSc;
    int tempScore = 0;
    public GameObject soundCont;
    public AudioClip coinCollectSound;

    GameObject coinParts;

    void Start()
    {
        coinScoreText.GetComponent<Text>().text = "Coins : " + PlayerPrefs.GetInt("coins").ToString();
    }

    IEnumerator cPartTimer()
    {
        yield return new WaitForSeconds(2);
        coinParts.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "coin")
        {
            soundCont.GetComponent<AudioSource>().PlayOneShot(coinCollectSound, 0.4f);

            coinParts = objectPoolSc.getCoinPart();
            coinParts.transform.position = col.gameObject.transform.position;
            coinParts.SetActive(true);
            col.gameObject.SetActive(false);
            tempScore = PlayerPrefs.GetInt("coins");
            tempScore++;
            PlayerPrefs.SetInt("coins", tempScore);
            coinScoreText.GetComponent<Animation>().Stop();
            coinScoreText.GetComponent<Animation>().Play();
            coinScoreText.GetComponent<Text>().text = "Coins : " + PlayerPrefs.GetInt("coins").ToString();
        }
    }
}
