using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOverSc : MonoBehaviour
{
    public GameObject gameOverCanvas, levelCont, pl, plPos, explosion, cam, campos, toucher, plat1, plat2, scoreScript, highCanvas, startPlat2, DistScore, fuelGauge, coinScoreText, fader, moon,admon;
    public camMove fuelSc;
    GameObject[] plats;
    GameObject[] coins;
    GameObject[] lvlToStop;

    void Start()
    {
        lvlToStop = GameObject.FindGameObjectsWithTag("lvlToStop");
    }

    IEnumerator deadWait()
    {
        yield return new WaitForSeconds(1);
        gameOverCanvas.SetActive(true);
    }

    IEnumerator toucherWait()
    {
        yield return new WaitForSeconds(2);
        toucher.GetComponent<Image>().raycastTarget = true;
    }

    public void deadWaitStarter()
    {
        foreach (GameObject things in lvlToStop)
        {
            things.SetActive(false);
        }
        StartCoroutine(deadWait());
    }

    IEnumerator playAgainTimer()
    {
        admon.GetComponent<admob>().ShowFullAds();

        gameOverCanvas.transform.GetChild(0).GetComponent<Animation>().Play("gameOverCanvasOff");
        yield return new WaitForSeconds(0.3f);
        fader.GetComponent<Animation>().Play("fadeInAnim");
        yield return new WaitForSeconds(0.6f);
        fader.GetComponent<Animation>().Play("fadeOutAnim");

        plats = GameObject.FindGameObjectsWithTag("plat");
        foreach (GameObject plat in plats)
        {
            plat.SetActive(false);
        }

        coins = GameObject.FindGameObjectsWithTag("coinP");
        foreach (GameObject coin in coins)
        {
            coin.SetActive(false);
        }

        foreach (GameObject things in lvlToStop)
        {
            things.SetActive(true);
        }
        highCanvas.SetActive(true);
        toucher.GetComponent<Controls>().touched = false;
        StartCoroutine(toucherWait());
        gameOverCanvas.SetActive(false);
        DistScore.SetActive(true);
        fuelGauge.SetActive(true);
        coinScoreText.SetActive(true);
        pl.transform.position = plPos.transform.position;
        pl.transform.rotation = plPos.transform.rotation;
        cam.transform.position = campos.transform.position;

        ParticleSystem.MainModule mainPart = plat2.transform.GetChild(1).GetComponent<ParticleSystem>().main;
        plat2.transform.GetChild(1).GetChild(0).gameObject.SetActive(true);
        ParticleSystem.MainModule mainPart2 = plat2.transform.GetChild(1).GetChild(0).GetComponent<ParticleSystem>().main;
        mainPart.loop = true;
        mainPart2.loop = true;
        plat2.transform.GetChild(0).gameObject.SetActive(true);

        ParticleSystem.MainModule mainPart3 = startPlat2.transform.GetChild(1).GetComponent<ParticleSystem>().main;
        startPlat2.transform.GetChild(1).GetChild(0).gameObject.SetActive(true);
        ParticleSystem.MainModule mainPart4 = startPlat2.transform.GetChild(1).GetChild(0).GetComponent<ParticleSystem>().main;
        mainPart3.loop = true;
        mainPart4.loop = true;
        startPlat2.transform.GetChild(0).gameObject.SetActive(true);
        startPlat2.SetActive(true);

        plat1.SetActive(true);
        plat2.SetActive(true);
        pl.SetActive(true);
        explosion.SetActive(false);
        fuelSc.fuelTimer = 0;
        scoreScript.GetComponent<scoreSc>().scoreTmp = pl.transform.position.x + 1.28f;
        scoreScript.GetComponent<scoreSc>().ScoreUpdaterNReset();
        pl.GetComponent<destroySc>().destroyed = false;
        moon.GetComponent<Animation>().Play();
        levelCont.SetActive(false);
        levelCont.SetActive(true);
    }

    public void playAgain()
    {
        StartCoroutine(playAgainTimer());
    }
}
