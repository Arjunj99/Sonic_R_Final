using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text totalTimeText;
    public Text roundTimeText;

    int totalTime;
    int roundOneTime;
    int roundTwoTime;
    int roundThreeTime;

    int min;
    int sec;
    int secFraction;
    private string minText;
    private string secText;
    private string secFractionText;



    void Update()
    {
        totalTime += Mathf.RoundToInt(Time.deltaTime * 100);
        ConvertToTimerText(totalTime, totalTimeText);
        
        roundOneTime += Mathf.RoundToInt(Time.deltaTime * 100);
        ConvertToTimerText(roundOneTime, roundTimeText);
    }

    void ConvertToTimerText(int timeHundreths, Text displayText)
    {
        secFraction = timeHundreths % 100;
        min = timeHundreths / 6000;
        sec = timeHundreths / 100 - (min * 60);
        
        if (min/10<1) 
        { 
            minText = ("0" + min); 
        }
        else 
        { 
            minText = (min + ""); 
        }
        
        if (sec/10<1) 
        { 
            secText = ("0" + sec); 
        }
        else 
        { 
            secText = (sec + ""); 
        }
        if (secFraction/10<1) 
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
