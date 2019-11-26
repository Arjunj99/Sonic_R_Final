using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public float mark1;
    public float mark2;




    // Start is called before the first frame update
    void Start()
    {
        lapNum1 = GameObject.Find("Player 1").GetComponent<Laps>().lapNum;
        lapNum2 = GameObject.Find("Player 2").GetComponent<Laps>().lapNum;
        distance1 = GameObject.Find("Player 1").GetComponent<Laps>().distanceToNext;
        distance2 = GameObject.Find("Player 2").GetComponent<Laps>().distanceToNext;
        mark1 = GameObject.Find("Player 1").GetComponent<Laps>().mark;
        mark2 = GameObject.Find("Player 2").GetComponent<Laps>().mark;
    }

    // Update is called once per frame
    void Update()
    {
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

        }
        else if (player1Infront == false)
        {

        }
    }
}
