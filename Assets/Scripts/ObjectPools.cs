using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPools : MonoBehaviour
{
    public GameObject platForm, platMoving, cPack1, cPack2, cPack3, cPack4, coinParticle;

    List<GameObject> Platpool;
    List<GameObject> PlatMovepool;
    List<GameObject> cPack1P;
    List<GameObject> cPack2P;
    List<GameObject> cPack3P;
    List<GameObject> cPack4P;
    List<GameObject> cPart;

    void Awake ()
    {
        Platpool= new List<GameObject>();
        PlatMovepool = new List<GameObject>();
        cPack1P = new List<GameObject>();
        cPack2P = new List<GameObject>();
        cPack3P = new List<GameObject>();
        cPack4P = new List<GameObject>();
        cPart = new List<GameObject>();

        for (int p = 0; p < 5; p++)
        {
            GameObject pPooler = (GameObject)Instantiate(platForm);
            pPooler.SetActive(false);
            Platpool.Add(pPooler);
        }

        for (int pm = 0; pm < 5; pm++)
        {
            GameObject pmPooler = (GameObject)Instantiate(platMoving);
            pmPooler.SetActive(false);
            PlatMovepool.Add(pmPooler);
        }

        for (int cp = 0; cp < 3; cp++)
        {
            GameObject cp1Pooler = (GameObject)Instantiate(cPack1);
            cp1Pooler.SetActive(false);
            cPack1P.Add(cp1Pooler);
        }

        for (int cp = 0; cp < 3; cp++)
        {
            GameObject cp2Pooler = (GameObject)Instantiate(cPack2);
            cp2Pooler.SetActive(false);
            cPack2P.Add(cp2Pooler);
        }

        for (int cp = 0; cp < 3; cp++)
        {
            GameObject cp3Pooler = (GameObject)Instantiate(cPack3);
            cp3Pooler.SetActive(false);
            cPack3P.Add(cp3Pooler);
        }

        for (int cp = 0; cp < 3; cp++)
        {
            GameObject cp4Pooler = (GameObject)Instantiate(cPack4);
            cp4Pooler.SetActive(false);
            cPack4P.Add(cp4Pooler);
        }

        for (int cpart = 0; cpart < 10; cpart++)
        {
            GameObject cpartPool = (GameObject)Instantiate(coinParticle);
            cpartPool.SetActive(false);
            cPart.Add(cpartPool);
        }
    }
	
    public GameObject getPlat()
    {
        for(int p = 0; p < Platpool.Count; p++)
        {
            if (!Platpool[p].activeInHierarchy)
                return Platpool[p];
        }

        GameObject pPooler = (GameObject)Instantiate(platForm);
        pPooler.SetActive(false);
        Platpool.Add(pPooler);
        return pPooler;
    }

    public GameObject getPlatMove()
    {
        for (int p = 0; p < PlatMovepool.Count; p++)
        {
            if (!PlatMovepool[p].activeInHierarchy)
                return PlatMovepool[p];
        }

        GameObject pmPooler = (GameObject)Instantiate(platMoving);
        pmPooler.SetActive(false);
        PlatMovepool.Add(pmPooler);
        return pmPooler;
    }

    public GameObject getCP1()
    {
        for (int p = 0; p < cPack1P.Count; p++)
        {
            if (!cPack1P[p].activeInHierarchy)
                return cPack1P[p];
        }

        GameObject cp1Pooler = (GameObject)Instantiate(cPack1);
        cp1Pooler.SetActive(false);
        cPack1P.Add(cp1Pooler);
        return cp1Pooler;
    }

    public GameObject getCP2()
    {
        for (int p = 0; p < cPack2P.Count; p++)
        {
            if (!cPack2P[p].activeInHierarchy)
                return cPack2P[p];
        }

        GameObject cp2Pooler = (GameObject)Instantiate(cPack2);
        cp2Pooler.SetActive(false);
        cPack1P.Add(cp2Pooler);
        return cp2Pooler;
    }

    public GameObject getCP3()
    {
        for (int p = 0; p < cPack3P.Count; p++)
        {
            if (!cPack3P[p].activeInHierarchy)
                return cPack3P[p];
        }

        GameObject cp3Pooler = (GameObject)Instantiate(cPack3);
        cp3Pooler.SetActive(false);
        cPack1P.Add(cp3Pooler);
        return cp3Pooler;
    }

    public GameObject getCP4()
    {
        for (int p = 0; p < cPack4P.Count; p++)
        {
            if (!cPack4P[p].activeInHierarchy)
                return cPack4P[p];
        }

        GameObject cp4Pooler = (GameObject)Instantiate(cPack4);
        cp4Pooler.SetActive(false);
        cPack4P.Add(cp4Pooler);
        return cp4Pooler;
    }

    public GameObject getCoinPart()
    {
        for (int p = 0; p < cPart.Count; p++)
        {
            if (!cPart[p].activeInHierarchy)
                return cPart[p];
        }

        GameObject cpartPool = (GameObject)Instantiate(coinParticle);
        cpartPool.SetActive(false);
        cPart.Add(cpartPool);
        return cpartPool;
    }
}
