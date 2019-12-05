using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ink : MonoBehaviour
{
    public bool hasSquid = false;
    public bool hasConfuse = false;
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

    public KeyCode useKey;

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

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(useKey))
        {
            if (hasSquid == true)
            {
                StartCoroutine("InOut");
            }
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Squid")
        { // If GameObject picks up a ring, add 1 to the score.
            if (hasSquid == false)
            {
                // StartCoroutine("InOut");
                Destroy(other.gameObject);
                hasSquid = true;
            }
        }

       
}

    IEnumerator InOut()
    {

        // Debug.Log("1");
        StartCoroutine("FadeIn");
        yield return new WaitForSeconds(5f);
        StartCoroutine("FadeOut");
        //yield return new WaitForSeconds(2f);
        //Destroy(gameObject);
    }

    IEnumerator FadeIn()
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


    IEnumerator FadeOut()
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