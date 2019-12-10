using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Laps : MonoBehaviour
{

    public GameObject mark1;
    public GameObject mark1x;
    public GameObject mark2;
    public GameObject mark2x;
    public GameObject mark3;

    public int lapNum;
   // public float markNum;

    public int mark;
    //public int markTotal;

    public bool firstLap = true;

    public bool passed1 = false;
    public bool passed1x = false;
    public bool passed2 = false;
    public bool passed2x = false;
    public bool passed3 = false;

  //  public bool reverse = false;

    public float distanceToNext;

    public Text lapsText;


   

    // Start is called before the first frame update
    void Start()
    {
        // reverseText = GameObject.Find("Reverse").GetComponent<Text>(); //updates UI text
        //reverseText.GetComponent<Text>().enabled = false;
       
    }

    // Update is called once per frame
    void Update()
    {


        if (lapNum < 5) //after 5 laps the player wins
        {
            lapsText.text = "Lap " + (lapNum + 1).ToString() + "/5";
           
        }

        else if (lapNum == 5) //after 5 laps the player wins
        {
            lapsText.text = "Lap " + (lapNum).ToString() + "/5";
            GetComponent<CharacterMovement>().enabled = false;

           


        }


        if (mark == 1)
        {
            distanceToNext = Vector3.Distance(this.transform.position, mark1x.transform.position);
        }
        else if (mark == 2)
        {
            distanceToNext = Vector3.Distance(this.transform.position, mark2.transform.position);
        }
        else if (mark == 3)
        {
            distanceToNext = Vector3.Distance(this.transform.position, mark2x.transform.position);
        }
        else if (mark == 4)
        {
            distanceToNext = Vector3.Distance(this.transform.position, mark3.transform.position);
        }
        else if (mark == 5)
        {
            distanceToNext = Vector3.Distance(this.transform.position, mark1.transform.position);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Cube1")
        {
   

            if (firstLap == true)
            {
                mark = 1;
                passed1 = true;
                firstLap = false;
            }
            else if (firstLap == false)
            {
                if (passed3 == true)
                {
                    // markTotal++;
                    mark = 1;
                    lapNum++;

                    /////////////////////////////////////////////Timer update
                    if (lapNum == 1)
                    {
                        GetComponent<Timer>().roundOneTime = GetComponent<Timer>().currentRoundTime;
                    }
                    if (lapNum == 2)
                    {
                        GetComponent<Timer>().roundTwoTime = GetComponent<Timer>().currentRoundTime;
                    }
                    if (lapNum == 3)
                    {
                        GetComponent<Timer>().roundThreeTime = GetComponent<Timer>().currentRoundTime;
                    }
                    if (lapNum == 4)
                    {
                        GetComponent<Timer>().roundFourTime = GetComponent<Timer>().currentRoundTime;
                    }
                    if (lapNum == 5)
                    {
                        GetComponent<Timer>().roundFiveTime = GetComponent<Timer>().currentRoundTime;
                        GetComponent<Timer>().counting = false;
                        GameObject.Find("PositionManager").GetComponent<Position>().playersCompleted++;
                    }
                    GetComponent<Timer>().currentRoundTime = 0;
                    /////////////////////////////////////////////Timer update
                    passed1 = true;
                    passed1x = false;
                    passed2 = false;
                    passed2x = false;
                    passed3 = false;

                }
                else if (passed3 == false)
                {
                    mark=0;
                }
            }
           

           

           
            
        }

        if (collision.gameObject.name == "Cube1x")
        {
          
            
           
            if (passed1 == true)
            {
                // markTotal++;
                mark = 2;
                passed1 = false;
                passed1x = true;
                passed2 = false;
                passed2x = false;
                passed3 = false;

            }
            else if (passed1 == false)
            {
                mark = 0;
            }

        }

        if (collision.gameObject.name == "Cube2")
        {
           
            
            if (passed1x == true)
            {
                // markTotal++;
                mark = 3;
                passed1 = false;
                passed1x = false;
                passed2 = true;
                passed2x = false;
                passed3 = false;
            
            }
            else if (passed1x == false)
            {
                mark = 0;
            }

        }
        if (collision.gameObject.name == "Cube2x")
        {
          
            



            if (passed2 == true)
            {
                // markTotal++;
                mark = 4;
                passed1 = false;
                passed1x = false;
                passed2 = false;
                passed2x = true;
                passed3 = false;

            }
            else if (passed2 == false)
            {
                mark = 0;
            }

        }
        if (collision.gameObject.name == "Cube3")
        {
           

           



            if (passed2x == true)
            {
                // markTotal++;
                mark = 5;
                passed1x = false;
                passed1 = false;
                passed2 = false;
                passed2x = false;
                passed3 = true;
               

            }
            else if (passed2x == false)
            {
                mark = 0;
            }

        }





    }

    }
