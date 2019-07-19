using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawner : MonoBehaviour
{
    public ObjectPools objectPooler;
    Vector2 platPos;
    public scoreSc scoreScript;
    int randomPlat, randomCoin;


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "pCol")
        {
            platPos = col.gameObject.transform.parent.transform.position;
            randomPlat = Random.Range(1, 4);
            randomCoin = Random.Range(1, 10);

            if (randomPlat == 1 || randomPlat == 3 || randomPlat == 4)
            {
                GameObject platSpawned = objectPooler.getPlat();
                platSpawned.transform.position = new Vector2(platPos.x + Random.Range(3f, 6f), Random.Range(-4.3f, 0.5f));                

                ParticleSystem.MainModule mainPart = platSpawned.transform.GetChild(1).GetComponent<ParticleSystem>().main;
                platSpawned.transform.GetChild(1).GetChild(0).gameObject.SetActive(true);
                ParticleSystem.MainModule mainPart2 = platSpawned.transform.GetChild(1).GetChild(0).GetComponent<ParticleSystem>().main;
                mainPart.loop = true;
                mainPart2.loop = true;
                platSpawned.transform.GetChild(0).gameObject.SetActive(true);
                platSpawned.SetActive(true);
            }

            else if(randomPlat == 2 && scoreScript.GetComponent<scoreSc>().score > 40)
            {
                GameObject platMoveSpawned = objectPooler.getPlatMove();
                platMoveSpawned.transform.position = new Vector2(platPos.x + Random.Range(3.5f, 6f), Random.Range(-2.5f, -1.5f));

                ParticleSystem.MainModule mainPart = platMoveSpawned.transform.GetChild(0).GetChild(0).GetComponent<ParticleSystem>().main;
                platMoveSpawned.transform.GetChild(0).GetChild(0).GetChild(0).gameObject.SetActive(true);
                ParticleSystem.MainModule mainPart2 = platMoveSpawned.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<ParticleSystem>().main;
                mainPart.loop = true;
                mainPart2.loop = true;
                platMoveSpawned.transform.GetChild(1).gameObject.SetActive(true);
                platMoveSpawned.SetActive(true);
            }
            else
            {
                GameObject platSpawned = objectPooler.getPlat();
                platSpawned.transform.position = new Vector2(platPos.x + Random.Range(3.5f, 6f), Random.Range(-4.3f, 0.5f));

                ParticleSystem.MainModule mainPart = platSpawned.transform.GetChild(1).GetComponent<ParticleSystem>().main;
                platSpawned.transform.GetChild(1).GetChild(0).gameObject.SetActive(true);
                ParticleSystem.MainModule mainPart2 = platSpawned.transform.GetChild(1).GetChild(0).GetComponent<ParticleSystem>().main;
                mainPart.loop = true;
                mainPart2.loop = true;
                platSpawned.transform.GetChild(0).gameObject.SetActive(true);
                platSpawned.SetActive(true);
            }

            if(randomCoin == 1 || randomCoin == 4)
            {
                GameObject coinPack = objectPooler.getCP4();
                coinPack.transform.position = new Vector2(platPos.x + 1.9f, Random.Range(platPos.y + 2.65f, platPos.y + 3.1f));
                coinPack.SetActive(true);
                for (int a = 0; a < coinPack.transform.childCount; a++)
                {
                    coinPack.transform.GetChild(a).gameObject.SetActive(true);
                }
            }

            else if (randomCoin == 2 || randomCoin == 8)
            {
                GameObject coinPack = objectPooler.getCP2();
                coinPack.transform.position = new Vector2(platPos.x + 1.9f, Random.Range(platPos.y + 2.65f, platPos.y + 3.1f));
                coinPack.SetActive(true);
                for (int a = 0; a < coinPack.transform.childCount; a++)
                {
                    coinPack.transform.GetChild(a).gameObject.SetActive(true);
                }
            }

            else if (randomCoin == 3 || randomCoin == 5)
            {
                GameObject coinPack = objectPooler.getCP3();
                coinPack.transform.position = new Vector2(platPos.x + 1.9f, Random.Range(platPos.y + 2.65f, platPos.y + 3.1f));
                coinPack.SetActive(true);
                for (int a = 0; a < coinPack.transform.childCount; a++)
                {
                    coinPack.transform.GetChild(a).gameObject.SetActive(true);
                }
            }

            else if (randomCoin == 6 || randomCoin == 7)
            {
                GameObject coinPack = objectPooler.getCP1();
                coinPack.transform.position = new Vector2(platPos.x + 1.9f, Random.Range(platPos.y + 2.65f, platPos.y + 3.1f));
                coinPack.SetActive(true);
                for (int a = 0; a < coinPack.transform.childCount; a++)
                {
                    coinPack.transform.GetChild(a).gameObject.SetActive(true);
                }
            }

            col.gameObject.SetActive(false);
        }
    }
}
