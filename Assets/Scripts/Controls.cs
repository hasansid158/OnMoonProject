using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Controls : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Vector2 powerXY;
    public GameObject fuelCol, pl;
    public ParticleSystem[] rocketParticles;
    RaycastHit2D rayhit;
    public bool touched;
    bool noFuel;

    void start()
    {
        powerXY = new Vector2(2, 4);
    }

    void FixedUpdate()
    {
        if (fuelCol.GetComponent<camMove>().fuelTimer < 2)
        {
            noFuel = false;
            if (touched)
            {
                pl.GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Clamp(pl.GetComponent<Rigidbody2D>().velocity.x, -1.5f, 1.5f), pl.GetComponent<Rigidbody2D>().velocity.y);
                pl.GetComponent<Rigidbody2D>().AddRelativeForce(powerXY, ForceMode2D.Force);
            }
        }
    }

    void Update()
    {
        if (touched)
        {
            if (fuelCol.GetComponent<camMove>().fuelTimer < 2)
            {
                fuelCol.GetComponent<camMove>().fuelTimer += Time.deltaTime;

                pl.GetComponent<AudioSource>().volume += 5f * Time.deltaTime;
                if (!pl.GetComponent<AudioSource>().isPlaying && pl.activeInHierarchy)
                {
                    pl.GetComponent<AudioSource>().Stop();
                    pl.GetComponent<AudioSource>().Play();
                }
            }

        }
        else
        {
            if (pl.GetComponent<AudioSource>().isPlaying)
            {
                pl.GetComponent<AudioSource>().volume -= 4f * Time.deltaTime;
                if (pl.GetComponent<AudioSource>().volume <= 0)
                {
                    pl.GetComponent<AudioSource>().Stop();
                }
            }
        }

        if(fuelCol.GetComponent<camMove>().fuelTimer > 2)
        {
            rocketParticles[PlayerPrefs.GetInt("sT",0)].Stop();
            noFuel = true;
        }

        if (noFuel)
        {
            pl.GetComponent<AudioSource>().volume -= 4f * Time.deltaTime;
            if (pl.GetComponent<AudioSource>().volume <= 0)
            {
                pl.GetComponent<AudioSource>().Stop();
            }
        }
    }

    public void OnPointerDown(PointerEventData pData)
    {
        pl.GetComponent<AudioSource>().volume = 0;
        touched = true;
        if (fuelCol.GetComponent<camMove>().fuelTimer < 2)
        {
            rocketParticles[PlayerPrefs.GetInt("sT",0)].Play();
        }
    }

    public void OnPointerUp(PointerEventData pData)
    {
        touched = false;
        if (rocketParticles[PlayerPrefs.GetInt("sT",0)].isPlaying)
        {
            rocketParticles[PlayerPrefs.GetInt("sT",0)].Stop();
        }
    }
}
