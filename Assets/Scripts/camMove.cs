using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camMove : MonoBehaviour
{
    public GameObject pl, cam, slider, landingTxt, sounds;
    public float fuelTimer, landTimer;
    bool touched;
    GameObject tempPart;
    int platNum;
    public AudioClip fuelSound;
    bool once;

    void Start()
    {
        fuelTimer = 0;
    }

    void FixedUpdate()
    {
        if (!pl.GetComponent<destroySc>().destroyed)
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(pl.transform.position.x + 3.2f, cam.transform.position.y, 0), 1 * Time.deltaTime);
        }
    }

    void Update()
    {
        slider.GetComponent<Slider>().value = fuelTimer;
        if (touched)
        {
            if (fuelTimer > 0)
            {
                fuelTimer -= Time.deltaTime;
                if (!once)
                {
                    once = true;
                    sounds.GetComponent<AudioSource>().PlayOneShot(fuelSound, 0.5f);
                }
            }
            else
            {
                sounds.GetComponent<AudioSource>().Stop();
                once = false;
            }
        }
        else
        {
            sounds.GetComponent<AudioSource>().Stop();
            once = false;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "plat")
        {
            tempPart = col.gameObject;
            touched = true;
            ParticleSystem.MainModule mainPart = tempPart.transform.GetChild(1).GetComponent<ParticleSystem>().main;
            ParticleSystem.MainModule mainPart2 = tempPart.transform.GetChild(1).GetChild(0).GetComponent<ParticleSystem>().main;
            mainPart.loop = false;
            mainPart2.loop = false;
        }
        if (col.gameObject.tag == "platm")
        {
            tempPart = col.gameObject;
            touched = true;
            ParticleSystem.MainModule mainPart = tempPart.transform.GetChild(0).GetComponent<ParticleSystem>().main;
            ParticleSystem.MainModule mainPart2 = tempPart.transform.GetChild(0).GetChild(0).GetComponent<ParticleSystem>().main;
            mainPart.loop = false;
            mainPart2.loop = false;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        sounds.GetComponent<AudioSource>().Stop();
        touched = false;
        landTimer = 0;
    }
}
