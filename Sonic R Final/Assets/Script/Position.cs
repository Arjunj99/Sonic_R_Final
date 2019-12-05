﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Position : MonoBehaviour
{

    public GameObject player1;
    public GameObject player2;

    public bool player1Infront;

   //public Laps lapscript1;
    public int lapNum1;
    public int lapNum2;
    public float distance1;
    public float distance2;
    public int mark1;
    public int mark2;


    public Text player1T;
    public Text player2T;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        lapNum1 = GameObject.Find("Player1").GetComponent<Laps>().lapNum;
        lapNum2 = GameObject.Find("Player2").GetComponent<Laps>().lapNum;
        distance1 = GameObject.Find("Player1").GetComponent<Laps>().distanceToNext;
        distance2 = GameObject.Find("Player2").GetComponent<Laps>().distanceToNext;
        mark1 = GameObject.Find("Player1").GetComponent<Laps>().mark;
        mark2 = GameObject.Find("Player2").GetComponent<Laps>().mark;
        

        if (lapNum1 > lapNum2)
        {
            player1Infront = true;

        }
        else if (lapNum1 < lapNum2)
        {
            player1Infront = false;
        }
        else if (lapNum1 == lapNum2)
        {
            if (mark1 > mark2)
            {
                player1Infront = true;
            }
            else if (mark1 < mark2)
            {
                player1Infront = false;
            }
            if (mark1 == mark2)
            {
                if (distance1 < distance2)
                {
                    player1Infront = true;
                }
                else if (distance1 > distance2)
                {
                    player1Infront = false;
                }

            }
        }



        if (player1Infront == true)
        {
            player1T.text = "Position 1/2";
            player2T.text = "Position 2/2";
        }
        else if (player1Infront == false)
        {
            player1T.text = "Position 2/2";
            player2T.text = "Position 1/2";
        }
    }
}
