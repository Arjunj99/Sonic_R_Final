﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class items : MonoBehaviour
{
    public bool hasSquid = false;
    public bool hasConfuse = false;
    public bool hasItem = false;
    public Image ink1;
    public Image ink2;
    public Image ink3;
    public Image ink4;
    public Image ink5;
    public Image ink6;
    public Image ink7;
    public Image ink8;
    public Image ink9;
    public Image ink10;

    public string useKey;

    public GameObject otherPlayer;
    public GameObject itemSpawner;

    public GameObject confusion;

    public AudioSource squid;
    public AudioSource confuse;
    public AudioSource oneshot;
    public AudioClip squidClip;
    // public AudioClip confuseClip;

    public Text youHave;

    // Start is called before the first frame update
    void Start()
    {
        ink1.CrossFadeAlpha(0, 0.0f, false);
        ink2.CrossFadeAlpha(0, 0.0f, false);
        ink3.CrossFadeAlpha(0, 0.0f, false);
        ink4.CrossFadeAlpha(0, 0.0f, false);
        ink5.CrossFadeAlpha(0, 0.0f, false);
        ink6.CrossFadeAlpha(0, 0.0f, false);
        ink7.CrossFadeAlpha(0, 0.0f, false);
        ink8.CrossFadeAlpha(0, 0.0f, false);
        ink9.CrossFadeAlpha(0, 0.0f, false);
        ink10.CrossFadeAlpha(0, 0.0f, false);

        confusion.SetActive(false);

    }
    
    // Update is called once per frame
    void Update()
    {

        if (hasSquid == true)
        {
            youHave.text = "You have Squid";
        }
        if (hasConfuse == true)
        {
            youHave.text = "You have Joker";
        }
        if (hasItem == false)
        {
            youHave.text = " ";
        }
        if (Input.GetButtonDown(useKey))
        {
            if (hasSquid == true)
            {
                StartCoroutine("InOutInk");
                squid.Play();
                hasSquid = false;
                hasItem = false;
            }
            if(hasConfuse == true)
            {
                StartCoroutine("InOutConfuse");
                confuse.Play();
                hasConfuse = false;
                hasItem = false;
            }
            
        }

    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Squid")
        {
            oneshot.PlayOneShot(squidClip);
            
             // If GameObject picks up a ring, add 1 to the score.
            if (hasItem == false) { 
                if (hasSquid == false)
                {
                    // StartCoroutine("InOut");
                    Destroy(other.gameObject);
                    itemSpawner.GetComponent<itemspawner>().squidGone = true;
                    hasSquid = true;
                    hasItem = true;
                }
            }
        }
        if (other.tag == "Confuse")
        {
            oneshot.PlayOneShot(squidClip);
             // If GameObject picks up a ring, add 1 to the score.
            if (hasItem == false)
            {
                if (hasConfuse == false)
                {
                    // StartCoroutine("InOut");
                    Destroy(other.gameObject);
                    itemSpawner.GetComponent<itemspawner>().confuseGone = true;
                    hasConfuse = true;
                    hasItem = true;
                }
            }
        }


    }

    IEnumerator InOutInk()
    {

        StartCoroutine("FadeInInk");
        yield return new WaitForSeconds(5f);
        StartCoroutine("FadeOutInk");
 
    }
    IEnumerator InOutConfuse()
    {
        Debug.Log(otherPlayer.name);
        otherPlayer.GetComponent<CharacterMovement>().invert = true;
        confusion.SetActive(true);
        
        yield return new WaitForSeconds(5f);
        otherPlayer.GetComponent<CharacterMovement>().invert = false;
        confusion.SetActive(false);

    }

    IEnumerator FadeInInk()
    {
        ink1.CrossFadeAlpha(1, 1.0f, false);
        ink2.CrossFadeAlpha(1, 1.0f, false);
        ink3.CrossFadeAlpha(1, 1.0f, false);
        ink4.CrossFadeAlpha(1, 1.0f, false);
        ink5.CrossFadeAlpha(1, 1.0f, false);
        ink6.CrossFadeAlpha(1, 1.0f, false);
        ink7.CrossFadeAlpha(1, 1.0f, false);
        ink8.CrossFadeAlpha(1, 1.0f, false);
        ink9.CrossFadeAlpha(1, 1.0f, false);
        ink10.CrossFadeAlpha(1, 1.0f, false);
        yield return new WaitForSeconds(0.5f);
    }


    IEnumerator FadeOutInk()
    {
        ink1.CrossFadeAlpha(0, 2.0f, false);
        ink2.CrossFadeAlpha(0, 1.5f, false);
        ink3.CrossFadeAlpha(0, 1.5f, false);
        ink4.CrossFadeAlpha(0, 1.5f, false);
        ink5.CrossFadeAlpha(0, 1.5f, false);
        ink6.CrossFadeAlpha(0, 1.0f, false);
        ink7.CrossFadeAlpha(0, 1.0f, false);
        ink8.CrossFadeAlpha(0, 1.0f, false);
        ink9.CrossFadeAlpha(0, 1.0f, false);
        ink10.CrossFadeAlpha(0, 1.0f, false);
        yield return new WaitForSeconds(0.5f);
    }
}