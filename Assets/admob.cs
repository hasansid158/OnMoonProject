using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class admob : MonoBehaviour
{
    BannerView banner;
    InterstitialAd fullAdmob;
    public string bannerId;
    public string idFull;

    void Start()
    {
        Application.targetFrameRate = 60;

        RequestBanner();
        ShowBanner();
        RequestFull();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void RequestBanner()
    {
        banner = new BannerView(bannerId, AdSize.Banner, AdPosition.Bottom);
        AdRequest adRequest = new AdRequest.Builder().Build();
        banner.LoadAd(adRequest);
    }
    public void ShowBanner()
    {
        banner.Show();
    }
    public void RequestFull()
    {
        fullAdmob = new InterstitialAd(idFull);
        AdRequest adRequest = new AdRequest.Builder().Build();
        fullAdmob.LoadAd(adRequest);
    }

    public void StopBanner()
    {
        banner.Hide();
        Debug.Log("Banner Hidden");
    }

    public void ShowFullAds()
    {
        if (fullAdmob.IsLoaded())
        {
            fullAdmob.Show();
            RequestFull();

        }
        else
        {
            RequestFull();
        }
    }
}