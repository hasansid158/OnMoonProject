using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopSc : MonoBehaviour
{
    public GameObject selectedCanvas0, selectedCanvas1, selectedCanvas2, selectedCanvas3, shopCanvas, gameOverCanvas, coinText;
    int tempCoin;
    public Text[] priceText;
    public GameObject[] coinImg, stCanvas;
    int selectedNum;

    void Start()
    {
        PlayerPrefs.SetInt("bt0", 1);
        selectedNum = PlayerPrefs.GetInt("stNum");
    }

    public void select_Thrust1()
    {
        if (PlayerPrefs.GetInt("sT") != 0)
        {
            PlayerPrefs.SetInt("sT", 0);
            selectedCanvas0.GetComponent<Animation>().Play();

            for (int a = 0; a < stCanvas.Length; a++)
            {
                if (PlayerPrefs.GetInt("bt" + a.ToString()) == 1 && PlayerPrefs.GetInt("sT") != selectedNum)
                {
                    stCanvas[selectedNum].GetComponent<Animation>().Play("boughtCloseAnim");
                    selectedNum = 0;
                    PlayerPrefs.SetInt("stNum", selectedNum);
                }
            }
        }
        else
        {
            if (!selectedCanvas0.GetComponent<Animation>().isPlaying)
            {
                selectedCanvas0.GetComponent<Animation>().Play("cantBuyAnim");
            }
        }
    }

    public void select_Thrust2()
    {
        if (PlayerPrefs.GetInt("coins") >= 250 && PlayerPrefs.GetInt("bt1", 0) == 0)
        {
            PlayerPrefs.SetInt("sT", 1);
            PlayerPrefs.SetInt("bt1", 1);

            tempCoin = PlayerPrefs.GetInt("coins");
            tempCoin -= 250;
            PlayerPrefs.SetInt("coins", tempCoin);
            coinText.GetComponent<Text>().text = PlayerPrefs.GetInt("coins").ToString();

            priceText[0].text = "Bought";
            coinImg[0].SetActive(false);

            selectedCanvas1.GetComponent<Animation>().Play();
            selectedCanvas1.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = "SELECTED";

            for (int a = 0; a < stCanvas.Length; a++)
            {
                if (PlayerPrefs.GetInt("bt" + a.ToString()) == 1 && PlayerPrefs.GetInt("sT") != selectedNum)
                {
                    stCanvas[selectedNum].GetComponent<Animation>().Play("boughtCloseAnim");
                    selectedNum = 1;
                    PlayerPrefs.SetInt("stNum", selectedNum);
                }
            }

        }
        else if (PlayerPrefs.GetInt("bt1") == 1 && PlayerPrefs.GetInt("sT") != 1)
        {
            PlayerPrefs.SetInt("sT", 1);
            selectedCanvas1.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = "SELECTED";

            selectedCanvas1.GetComponent<Animation>().Play();

            for (int a = 0; a < stCanvas.Length; a++)
            {
                if (PlayerPrefs.GetInt("bt" + a.ToString()) == 1 && PlayerPrefs.GetInt("sT") != selectedNum)
                {
                    stCanvas[selectedNum].GetComponent<Animation>().Play("boughtCloseAnim");
                    selectedNum = 1;
                    PlayerPrefs.SetInt("stNum", selectedNum);
                }
            }
        }
        else
        {
            if (!selectedCanvas1.GetComponent<Animation>().isPlaying)
            {
                selectedCanvas1.GetComponent<Animation>().Play("cantBuyAnim");
            }
        }
    }
    
    public void select_Thrust3()
    {
        if (PlayerPrefs.GetInt("coins") >= 850 && PlayerPrefs.GetInt("bt2", 0) == 0)
        {
            PlayerPrefs.SetInt("sT", 2);
            PlayerPrefs.SetInt("bt2", 1);

            tempCoin = PlayerPrefs.GetInt("coins");
            tempCoin -= 1200;
            PlayerPrefs.SetInt("coins", tempCoin);
            coinText.GetComponent<Text>().text = PlayerPrefs.GetInt("coins").ToString();

            priceText[1].text = "Bought";
            coinImg[1].SetActive(false);

            selectedCanvas2.GetComponent<Animation>().Play();
            selectedCanvas2.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = "SELECTED";

            for (int a = 0; a < stCanvas.Length; a++)
            {
                if (PlayerPrefs.GetInt("bt" + a.ToString()) == 1 && PlayerPrefs.GetInt("sT") != selectedNum)
                {
                    stCanvas[selectedNum].GetComponent<Animation>().Play("boughtCloseAnim");
                    selectedNum = 2;
                    PlayerPrefs.SetInt("stNum", selectedNum);
                }
            }
        }
        else if (PlayerPrefs.GetInt("bt2") == 1 && PlayerPrefs.GetInt("sT") != 2)
        {
            PlayerPrefs.SetInt("sT", 2);
            selectedCanvas2.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = "SELECTED";

            selectedCanvas2.GetComponent<Animation>().Play();

            for (int a = 0; a < stCanvas.Length; a++)
            {
                if (PlayerPrefs.GetInt("bt" + a.ToString()) == 1 && PlayerPrefs.GetInt("sT") != selectedNum)
                {
                    stCanvas[selectedNum].GetComponent<Animation>().Play("boughtCloseAnim");
                    selectedNum = 2;
                    PlayerPrefs.SetInt("stNum", selectedNum);
                }
            }
        }
        else
        {
            if (!selectedCanvas2.GetComponent<Animation>().isPlaying)
            {
                selectedCanvas2.GetComponent<Animation>().Play("cantBuyAnim");
            }
        }
    }

    public void select_Thrust4()
    {
        if (PlayerPrefs.GetInt("coins") >= 1500 && PlayerPrefs.GetInt("bt3", 0) == 0)
        {
            PlayerPrefs.SetInt("sT", 3);
            PlayerPrefs.SetInt("bt3", 1);

            tempCoin = PlayerPrefs.GetInt("coins");
            tempCoin -= 1500;
            PlayerPrefs.SetInt("coins", tempCoin);
            coinText.GetComponent<Text>().text = PlayerPrefs.GetInt("coins").ToString();

            priceText[2].text = "Bought";
            coinImg[2].SetActive(false);

            selectedCanvas3.GetComponent<Animation>().Play();
            selectedCanvas3.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = "SELECTED";

            for (int a = 0; a < stCanvas.Length; a++)
            {
                if (PlayerPrefs.GetInt("bt" + a.ToString()) == 1 && PlayerPrefs.GetInt("sT") != selectedNum)
                {
                    stCanvas[selectedNum].GetComponent<Animation>().Play("boughtCloseAnim");
                    selectedNum = 3;
                    PlayerPrefs.SetInt("stNum", selectedNum);
                }
            }

        }
        else if (PlayerPrefs.GetInt("bt3") == 1 && PlayerPrefs.GetInt("sT") != 3)
        {
            PlayerPrefs.SetInt("sT", 3);
            selectedCanvas3.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = "SELECTED";

            selectedCanvas3.GetComponent<Animation>().Play();

            for (int a = 0; a < stCanvas.Length; a++)
            {
                if (PlayerPrefs.GetInt("bt" + a.ToString()) == 1 && PlayerPrefs.GetInt("sT") != selectedNum)
                {
                    stCanvas[selectedNum].GetComponent<Animation>().Play("boughtCloseAnim");
                    selectedNum = 3;
                    PlayerPrefs.SetInt("stNum", selectedNum);
                }
            }
        }
        else
        {
            if (!selectedCanvas3.GetComponent<Animation>().isPlaying)
            {
                selectedCanvas3.GetComponent<Animation>().Play("cantBuyAnim");
            }
        }
    }

    IEnumerator shopOffTimer()
    {
        shopCanvas.transform.GetChild(0).GetComponent<Animation>().Play("shopAnimOff");
        yield return new WaitForSeconds(0.3f);
        gameOverCanvas.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        shopCanvas.SetActive(false);
    }

    IEnumerator shopOnTimer()
    {
        gameOverCanvas.transform.GetChild(0).GetComponent<Animation>().Play("gameOverCanvasOff");
        yield return new WaitForSeconds(0.35f);
        gameOverCanvas.SetActive(false);
        coinText.GetComponent<Text>().text = PlayerPrefs.GetInt("coins").ToString();
        shopCanvas.SetActive(true);
    }

    public void shopOff()
    {
        StartCoroutine(shopOffTimer());
    }

    public void shopOn()
    {
        for (int a = 1; a < priceText.Length + 1; a++)
        {
            if (PlayerPrefs.GetInt("bt" + a.ToString()) == 1)
            {
                priceText[a - 1].text = "Bought";
                coinImg[a - 1].SetActive(false);
            }
        }
        for (int b = 0; b < stCanvas.Length; b++)
        {
            if (PlayerPrefs.GetInt("bt" + b.ToString(), 0) == 1)
            {
                stCanvas[b].transform.GetChild(0).GetChild(0).GetComponent<Text>().text = "SELECTED";

                if (PlayerPrefs.GetInt("sT") != b)
                {
                    stCanvas[b].GetComponent<Animation>().Play("boughtCloseAnim");
                }
            }

        }
        StartCoroutine(shopOnTimer());
    }
}
