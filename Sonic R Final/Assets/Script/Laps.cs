using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laps : MonoBehaviour
{

    public GameObject mark1;
    public GameObject mark2;
    public GameObject mark3;

    public int lapNum;
   // public float markNum;

    public int mark;

    public bool passed1 = false;
    public bool passed2 = false;
    public bool passed3 = false;

    public bool reverse = false;

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
            distanceToNext = Vector3.Distance(this.transform.position, mark2.transform.position);
        }
        else if (mark == 2)
        {
            distanceToNext = Vector3.Distance(this.transform.position, mark3.transform.position);
        }
        else if (mark == 3)
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

           

            if (passed3 == true)
            {
                lapNum++;
                passed2 = false;
                passed3 = false;
                reverse = false;
            }
            else if (passed2 == false)
            {
               // reverse = true;
            }
        }

        if (collision.gameObject.name == "Cube2")
        {
            
            mark = 2;
            if (passed1 == true)
            {
                passed2 = true;
                passed1 = false;
                passed3 = false;
                reverse = false;
            }
            else if (passed1 == false)
            {
                //reverse = true;
            }
        }

        if (collision.gameObject.name == "Cube3")
        {
           
            mark = 3;
            if (passed2 == true)
            {
                passed3 = true;
                passed1 = false;
                passed2 = false;
                reverse = false;
            }
            else if (passed2 == false)
            {
                //reverse = true;
            }
        }

       
    }

    }
