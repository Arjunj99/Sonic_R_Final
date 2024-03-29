﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoredisplay : MonoBehaviour
{
    public Text p1totalTimeText;
    public Text p1round1TimeText;
    public Text p1round2TimeText;
    public Text p1round3TimeText;
    public Text p1round4TimeText;
    public Text p1round5TimeText;

    public Text p2totalTimeText;
    public Text p2round1TimeText;
    public Text p2round2TimeText;
    public Text p2round3TimeText;
    public Text p2round4TimeText;
    public Text p2round5TimeText;

    public int p1totalTime;
    public int p1roundOneTime;
    public int p1roundTwoTime;
    public int p1roundThreeTime;
    public int p1roundFourTime;
    public int p1roundFiveTime;

    public int p2totalTime;
    public int p2roundOneTime;
    public int p2roundTwoTime;
    public int p2roundThreeTime;
    public int p2roundFourTime;
    public int p2roundFiveTime;

    int min;
    int sec;
    int secFraction;
    private string minText;
    private string secText;
    private string secFractionText;
    // Start is called before the first frame update
    void Start()
    {
        p1totalTime = GameManager.instance.p1totalTime;
        p1roundOneTime = GameManager.instance.p1roundOneTime;
        p1roundTwoTime = GameManager.instance.p1roundTwoTime;
        p1roundThreeTime = GameManager.instance.p1roundThreeTime;
        p1roundFourTime = GameManager.instance.p1roundFourTime;
        p1roundFiveTime = GameManager.instance.p1roundFiveTime;

        p2totalTime = GameManager.instance.p2totalTime;
        p2roundOneTime = GameManager.instance.p2roundOneTime;
        p2roundTwoTime = GameManager.instance.p2roundTwoTime;
        p2roundThreeTime = GameManager.instance.p2roundThreeTime;
        p2roundFourTime = GameManager.instance.p2roundFourTime;
        p2roundFiveTime = GameManager.instance.p2roundFiveTime;
    }

    // Update is called once per frame
    void Update()
    {
        ConvertToTimerText(p1totalTime, p1totalTimeText);
        ConvertToTimerText(p1roundOneTime, p1round1TimeText);
        ConvertToTimerText(p1roundTwoTime, p1round2TimeText);
        ConvertToTimerText(p1roundThreeTime, p1round3TimeText);
        ConvertToTimerText(p1roundFourTime, p1round4TimeText);
        ConvertToTimerText(p1roundFiveTime, p1round5TimeText); 

        ConvertToTimerText(p2totalTime, p2totalTimeText);
        ConvertToTimerText(p2roundOneTime, p2round1TimeText);
        ConvertToTimerText(p2roundTwoTime, p2round2TimeText);
        ConvertToTimerText(p2roundThreeTime, p2round3TimeText);
        ConvertToTimerText(p2roundFourTime, p2round4TimeText);
        ConvertToTimerText(p2roundFiveTime, p2round5TimeText);


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
}
