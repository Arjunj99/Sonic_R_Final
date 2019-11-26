using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public float distanceToNext;

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Lap: "+lapNum);

        Debug.Log("Mark:"+mark);

        Debug.Log("Distance: " +  distanceToNext);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Cube1")
        {
            passed1 = true;

            mark = 1;

            distanceToNext= Vector3.Distance(this.transform.position, mark2.transform.position);

            if (passed3 == true)
            {
                lapNum++;
                passed2 = false;
                passed3 = false;
            }
        }

        if (collision.gameObject.name == "Cube2")
        {
            distanceToNext = Vector3.Distance(this.transform.position, mark3.transform.position);
            mark = 2;
            if (passed1 == true)
            {
                passed2 = true;
                passed1 = false;
                passed3 = false;
            }
        }

        if (collision.gameObject.name == "Cube3")
        {
            distanceToNext = Vector3.Distance(this.transform.position, mark1.transform.position);
            mark = 3;
            if (passed2 == true)
            {
                passed3 = true;
                passed1 = false;
                passed2 = false;
            }
        }
    }

    }
