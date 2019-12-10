using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
​
public class Timer : MonoBehaviour
{
    
<<<<<<< HEAD
​
    public Text totalTimeText;
    public Text roundTimeText;
​
    public int totalTime;
​
=======

    public Text totalTimeText;
    public Text roundTimeText;

    public int totalTime;

>>>>>>> edf3b10ae448ccdf49e252ae9aef6cd178476c2d
    public int currentRoundTime;
    public int roundOneTime;
    public int roundTwoTime;
    public int roundThreeTime;
    public int roundFourTime;
    public int roundFiveTime;
<<<<<<< HEAD
​
    public bool counting=true;
​
=======

    public bool counting=true;

>>>>>>> edf3b10ae448ccdf49e252ae9aef6cd178476c2d
    int min;
    int sec;
    int secFraction;
    private string minText;
    private string secText;
    private string secFractionText;
<<<<<<< HEAD
​
=======

>>>>>>> edf3b10ae448ccdf49e252ae9aef6cd178476c2d
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
<<<<<<< HEAD
​
=======

>>>>>>> edf3b10ae448ccdf49e252ae9aef6cd178476c2d
    void Update()
    {
        if (counting == true) //doesn't keep counting after player completes game
        { 
        totalTime += Mathf.RoundToInt(Time.deltaTime * 100);
        currentRoundTime += Mathf.RoundToInt(Time.deltaTime * 100);
        }
<<<<<<< HEAD
​
        ConvertToTimerText(totalTime, totalTimeText);
 
        ConvertToTimerText(currentRoundTime, roundTimeText);
​
=======

        ConvertToTimerText(totalTime, totalTimeText);
 
        ConvertToTimerText(currentRoundTime, roundTimeText);

>>>>>>> edf3b10ae448ccdf49e252ae9aef6cd178476c2d
        
    }
​
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
​
        displayText.text = (minText + ":" + secText + ":" + secFractionText);
    }
​
}