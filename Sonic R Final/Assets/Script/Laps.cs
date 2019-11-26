using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laps : MonoBehaviour
{

    public GameObject mark1;
    public GameObject mark2;
    public GameObject mark3;

    public int lapNum;

    public bool passed1 = false;
    public bool passed2 = false;
    public bool passed3 = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Lap: "+lapNum);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Cube1")
        {
            passed1 = true;

            if (passed3 == true)
            {
                lapNum++;
                passed2 = false;
                passed3 = false;
            }
        }

        if (collision.gameObject.name == "Cube2")
        {
            if (passed1 == true)
            {
                passed2 = true;
                passed1 = false;
                passed3 = false;
            }
        }

        if (collision.gameObject.name == "Cube3")
        {
            if (passed2 == true)
            {
                passed3 = true;
                passed1 = false;
                passed2 = false;
            }
        }
    }

    }
