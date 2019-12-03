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
    public int markTotal;

    public bool firstLap = true;

    public bool passed1 = false;
    public bool passed1x = false;
    public bool passed2 = false;
    public bool passed2x = false;
    public bool passed3 = false;

  //  public bool reverse = false;

    public float distanceToNext;

    public Text lapsText;
    //public Text reverseText;


    // Start is called before the first frame update
    void Start()
    {
       // reverseText = GameObject.Find("Reverse").GetComponent<Text>(); //updates UI text
        //reverseText.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //  Debug.Log("Lap: "+lapNum);

        //  Debug.Log("Mark:"+mark);

        // Debug.Log("Distance: " +  distanceToNext);
        if (lapNum == 5) //after 5 laps the player wins
        {
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
            passed1 = true;

            mark = 1;

            if (firstLap == true)
            {
                markTotal++;
                firstLap = false;
            }
            else if (firstLap == false)
            {
                if (passed3 == true)
                {
                    markTotal++;
                    lapNum++;
                    passed1x = false;
                    passed2 = false;
                    passed2x = false;
                    passed3 = false;

                }
            }
           

           

           
            
        }

        if (collision.gameObject.name == "Cube1x")
        {
          
            
            mark = 2;
            if (passed1 == true)
            {
                markTotal++;

                passed1 = false;
                passed1x = true;
                passed2 = false;
                passed2x = false;
                passed3 = false;

            }
           
        }

        if (collision.gameObject.name == "Cube2")
        {
           
            mark = 3;
            if (passed1x == true)
            {
                markTotal++;

                passed1 = false;
                passed1x = false;
                passed2 = true;
                passed2x = false;
                passed3 = false;
            
            }
           
        }
        if (collision.gameObject.name == "Cube2x")
        {
          
            mark = 4;



            if (passed2 == true)
            {
                markTotal++;

                passed1 = false;
                passed1x = false;
                passed2 = false;
                passed2x = true;
                passed3 = false;

            }

        }
        if (collision.gameObject.name == "Cube3")
        {
           

            mark = 5;



            if (passed2x == true)
            {
                markTotal++;

                passed1x = false;
                passed1 = false;
                passed2 = false;
                passed2x = false;
                passed3 = true;
               

            }

        }





    }

    }
