using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startButtonSc : MonoBehaviour
{
    public GameObject moon, lvlCont, playBut, toucher;
    public Animation[] menuText;

    IEnumerator starter()
    {
        playBut.GetComponent<Animation>().Play("playButFade");
        for(int a =0; a < menuText.Length; a++)
        {
            menuText[a].Play();
        }
        yield return new WaitForSeconds(0.5f);
        playBut.SetActive(false);
        for (int a = 0; a < menuText.Length; a++)
        {
            menuText[a].gameObject.SetActive(false);
        }
        yield return new WaitForSeconds(1.5f);
        toucher.GetComponent<Image>().raycastTarget = true;
    }

    public void startBut()
    {
        StartCoroutine(starter());
        moon.GetComponent<Animation>().Play();
        lvlCont.SetActive(true);
        StartCoroutine(starter());
    }
}
