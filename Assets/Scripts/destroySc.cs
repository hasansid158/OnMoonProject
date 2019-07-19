using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroySc : MonoBehaviour
{
    public GameObject explosion, cam, plDestroyer, scoreSc, scCont, toucher, DistScore, fuelGauge, coinScoreText, sounds;
    public Text overScore, overHighScore, overCoinScore;
    public bool destroyed;
    public AudioClip destroySound;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "plat" || col.gameObject.tag == "sPlat" || col.gameObject.tag == "platm")
        {
            sounds.GetComponent<AudioSource>().PlayOneShot(destroySound, 1);

            toucher.GetComponent<Image>().raycastTarget = false;
            scCont.GetComponent<gameOverSc>().deadWaitStarter();
            overScore.text = scoreSc.GetComponent<scoreSc>().score.ToString("F1");
            overHighScore.text = PlayerPrefs.GetFloat("highScore").ToString("F1");
            overCoinScore.text = PlayerPrefs.GetInt("coins").ToString();
            DistScore.SetActive(false);
            fuelGauge.SetActive(false);
            coinScoreText.SetActive(false);
            destroyed = true;
            explosion.transform.position = new Vector3(transform.position.x, transform.position.y, -1);
            explosion.SetActive(true);
            cam.GetComponent<Animation>().Play();

            if (PlayerPrefs.GetFloat("highScore") < scoreSc.GetComponent<scoreSc>().score)
            {
                PlayerPrefs.SetFloat("highScore", scoreSc.GetComponent<scoreSc>().score);
            }
            gameObject.SetActive(false);
        }

        else if(col.gameObject == plDestroyer)
        {
            sounds.GetComponent<AudioSource>().PlayOneShot(destroySound, 1);

            toucher.GetComponent<Image>().raycastTarget = false;
            scCont.GetComponent<gameOverSc>().deadWaitStarter();
            overScore.text = scoreSc.GetComponent<scoreSc>().score.ToString("F1");
            overHighScore.text = PlayerPrefs.GetFloat("highScore").ToString("F1");
            overCoinScore.text = PlayerPrefs.GetInt("coins").ToString();
            DistScore.SetActive(false);
            fuelGauge.SetActive(false);
            coinScoreText.SetActive(false);
            destroyed = true;
            explosion.transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, -1);
            explosion.SetActive(true);
            cam.GetComponent<Animation>().Play();

            if (PlayerPrefs.GetFloat("highScore") < scoreSc.GetComponent<scoreSc>().score)
            {
                PlayerPrefs.SetFloat("highScore", scoreSc.GetComponent<scoreSc>().score);
            }

            gameObject.SetActive(false);
        }
    }
}
