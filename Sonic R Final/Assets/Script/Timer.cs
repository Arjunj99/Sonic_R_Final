using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{


    public Text totalTimeText;
    public Text roundTimeText;

    public int totalTime;

    public int currentRoundTime;
    public int roundOneTime;
    public int roundTwoTime;
    public int roundThreeTime;
    public int roundFourTime;
    public int roundFiveTime;

    public bool counting = true;

    int min;
    int sec;
    int secFraction;
    private string minText;
    private string secText;
    private string secFractionText;

    public bool isPlayerOne;

    private void Awake()
    {
       // DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (counting == true) //doesn't keep counting after player completes game
        {
            totalTime += Mathf.RoundToInt(Time.deltaTime * 100);
            currentRoundTime += Mathf.RoundToInt(Time.deltaTime * 100);
        }

        ConvertToTimerText(totalTime, totalTimeText);

        ConvertToTimerText(currentRoundTime, roundTimeText);


    }

    void ConvertToTimerText(int timeHundreths, Text displayText)
    {
        secFraction = timeHundreths % 100;
        min = timeHundreths / 6000;
        sec = timeHundreths / 100 - (min * 60);

        if (min / 10 < 1)
        {
            minText = ("0" + min);
        }
        else
        {
            minText = (min + "");
        }

        if (sec / 10 < 1)
        {
            secText = ("0" + sec);
        }
        else
        {
            secText = (sec + "");
        }

        if (secFraction / 10 < 1)
        {
            secFractionText = ("0" + secFraction);
        }
        else
        {
            secFractionText = (secFraction + "");
        }

        displayText.text = (minText + ":" + secText + ":" + secFractionText);
    }

    public void SetGameManagerTimes()
    {
        if (isPlayerOne)
        {
            GameManager.instance.p1totalTime = totalTime;
        }
        else
        {
            GameManager.instance.p2totalTime = totalTime;
        }
    }

}