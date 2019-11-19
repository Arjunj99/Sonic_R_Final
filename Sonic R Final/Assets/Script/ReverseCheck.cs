using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReverseCheck : MonoBehaviour
{
    public GameObject mark1;
    public GameObject mark2;
    public GameObject mark3;


    public bool onRoad = true;

    public bool passedM1 = false;
    public bool passedM2 = false;
    public bool passedMx = false;

    public bool reverse = false;

    public bool lastDistMax = true;

    public float lastDist;

    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        

        text = GameObject.Find("Text").GetComponent<Text>();
        text.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
      //  if (onRoad == true) { 

        if (passedM1 == true)
        {
                Debug.Log(lastDist);
                // Debug.Log(lastDist);

                //   lastDistMax = false;

                // lastDist = Vector3.Distance(mark1.transform.position, mark2.transform.position); //set initial distance

                //lastDist = Vector3.Distance(this.transform.position, mark2.transform.position);

                if (lastDistMax == true)
            {
                lastDist = Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark2.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark2.transform.position.z), 2f)); //reset lastDist so there won't be one frame of "REVERSE" appearing

                lastDistMax = false;
            }

            if (Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark2.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark2.transform.position.z), 2f)) < lastDist)
            {
                // Debug.Log("Reverse!");
                Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark2.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark2.transform.position.z), 2f));
                reverse = false;
            }
            else if (Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark2.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark2.transform.position.z), 2f)) > lastDist)
            {
                // Debug.Log("Reverse!");
                Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark2.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark2.transform.position.z), 2f));
                reverse = true; 
            }
           

        }


        if (passedM2 == true)
        {
            Debug.Log(lastDist);
            //  lastDistMax = false;
            if (lastDistMax == true)
            {
                lastDist = Vector3.Distance(this.transform.position, mark3.transform.position); //reset lastDist so there won't be one frame of "REVERSE" appearing
                lastDistMax = false;
            }
            //lastDist = Vector3.Distance(this.transform.position, mark2.transform.position);
            if (Vector3.Distance(this.transform.position, mark3.transform.position) > lastDist)
            {
                Debug.Log("Reverse!");
                lastDist = Vector3.Distance(this.transform.position, mark3.transform.position);
                reverse = true;
            }
            else if (Vector3.Distance(this.transform.position, mark3.transform.position) < lastDist)
            {
                // Debug.Log("Reverse!");
                lastDist = Vector3.Distance(this.transform.position, mark3.transform.position);
                reverse = false;
            }

        }

        //if (lastDistMax == true)
        //{
        //    lastDist = 100;
        //}

        if (reverse == true)
        {
            
            text.GetComponent<Text>().enabled = true;
          
            
        }
        else if (reverse == false)
        {
            text.GetComponent<Text>().enabled = false;
        }
            //  Debug.Log(Vector3.Distance(this.transform.position, mark1.transform.position));
            //Debug.Log(Vector3.Distance(this.transform.position, mark2.transform.position));

      //  }


    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Cube1")
        {
            lastDistMax = true;
            passedM1 = true;
            passedM2 = false;
            passedMx = false;
            Debug.Log("entered");
        }
        if (collision.gameObject.name == "Cube2")
        {
            lastDistMax = true;
            passedM2 = true;
            passedM1 = false;
            passedMx = false;
            Debug.Log("entered");
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    onRoad = true;
    //    Debug.Log("land");
    //}


    //private void OnCollisionExit(Collision collision)
    //{
    //    onRoad = false;
    //    Debug.Log("jump");
    //}
}
