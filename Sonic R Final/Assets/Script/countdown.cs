using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    public Text three;
    public Text two;
    public Text one;
    public Text go;

    public bool roundstart = true;

   

    // Start is called before the first frame update
    void Start()
    {
        three.CrossFadeAlpha(0, 0.0f, false);
        two.CrossFadeAlpha(0, 0.0f, false);
        one.CrossFadeAlpha(0, 0.0f, false);
        go.CrossFadeAlpha(0, 0.0f, false);
        GetComponent<CharacterMovement>().enabled = false;
        GetComponent<Timer>().enabled = false;



    }

    // Update is called once per frame
    void Update()
    {
        if (roundstart)
        {
            StartCoroutine("Countdown");
           
            roundstart = false;
        }
    }
    IEnumerator Countdown()
    {

        StartCoroutine("FadeIn3");
        yield return new WaitForSeconds(1f);
        StartCoroutine("FadeOut3");
        yield return new WaitForSeconds(0.25f);
        StartCoroutine("FadeIn2");
        yield return new WaitForSeconds(1f);
        StartCoroutine("FadeOut2");
        yield return new WaitForSeconds(0.25f);
        StartCoroutine("FadeIn1");
        yield return new WaitForSeconds(1f);
        StartCoroutine("FadeOut1");
        yield return new WaitForSeconds(0.25f);
        StartCoroutine("FadeInGo"); 
        GetComponent<CharacterMovement>().enabled = true;
        GetComponent<Timer>().enabled = true;

        yield return new WaitForSeconds(1f);
        StartCoroutine("FadeOutGo");
        yield return new WaitForSeconds(0.25f);
        


    }
    IEnumerator FadeIn3()
    {
        three.CrossFadeAlpha(1, 1f, false);
        
        yield return new WaitForSeconds(0f);
    }
    IEnumerator FadeOut3()
    {
        three.CrossFadeAlpha(0, 0.25f, false);

        yield return new WaitForSeconds(0f);
    }
    IEnumerator FadeIn2()
    {
        two.CrossFadeAlpha(1, 1.0f, false);

        yield return new WaitForSeconds(0f);
    }
    IEnumerator FadeOut2()
    {
        two.CrossFadeAlpha(0, 0.25f, false);

        yield return new WaitForSeconds(0f);
    }

    IEnumerator FadeIn1()
    {
        one.CrossFadeAlpha(1, 1.0f, false);

        yield return new WaitForSeconds(0f);
    }
    IEnumerator FadeOut1()
    {
        one.CrossFadeAlpha(0, 0.25f, false);

        yield return new WaitForSeconds(0f);
    }

    IEnumerator FadeInGo()
    {
        go.CrossFadeAlpha(1, 1.0f, false);

        yield return new WaitForSeconds(0f);
    }
    IEnumerator FadeOutGo()
    {
        go.CrossFadeAlpha(0, 0.25f, false);

        yield return new WaitForSeconds(0f);
    }
}
