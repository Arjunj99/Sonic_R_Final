using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int totalTime;
    public int min;
    public int sec;
    public int secFraction;
    public Text finalTime;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalTime += Mathf.RoundToInt(Time.deltaTime * 100);
        secFraction = totalTime %100;
        min = totalTime / 6000;
        sec = totalTime / 100-(min*60);
        finalTime.text = (min+":"+sec+":"+secFraction);
    }
    
}
