using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReverseCheck : MonoBehaviour
{
    public GameObject mark1;
    public GameObject mark1x;
    public GameObject mark2;
    public GameObject mark2x;
    public GameObject mark3;


    public bool onRoad = true;

    public bool passedM1 = false;
    public bool passedM1x = false;
    public bool passedM2 = false;
    public bool passedM2x = false;
    public bool passedM3 = false;

    public bool reverse = false;

    public bool lastDistMax = true;

    public float lastDist;

    public Text text;
    public GameObject textBG;

    public float timeinReverse;
    public float timenotReverse;
    // Start is called before the first frame update
    void Start()
    {
        

      //  text = GameObject.Find("Text").GetComponent<Text>(); //updates UI text
        text.GetComponent<Text>().enabled = false;
        textBG.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
      //  if (onRoad == true) { 

        if (passedM1 == true)
        {
                Debug.Log(lastDist);
                // Debug.Log(lastDist);

             

                if (lastDistMax == true)//reset lastDist so there won't be one frame of "REVERSE" appearing
            {
                lastDist = Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark1x.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark1x.transform.position.z), 2f)); //use pythagorean theorem to calculate distance that disregards y axis  

                lastDistMax = false;
            }

            if (Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark1x.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark1x.transform.position.z), 2f)) < lastDist)
            {
              
                lastDist = Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark1x.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark1x.transform.position.z), 2f));
                /////////////////////////////////////
                timeinReverse = 0;

                timenotReverse += Time.deltaTime;
                if (timenotReverse > 0.5)
                {
                    reverse = false;
                }
            }
            else if (Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark1x.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark1x.transform.position.z), 2f)) > lastDist)
            {
                 Debug.Log("Reverse!");
                lastDist = Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark1x.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark1x.transform.position.z), 2f));
                /////////////////////////////////////
                timenotReverse = 0;

                timeinReverse += Time.deltaTime;

                if (timeinReverse > 2)
                {
                    reverse = true;
                }
            }
           

        }

        if (passedM1x == true)
        {
            Debug.Log(lastDist);
            // Debug.Log(lastDist);



            if (lastDistMax == true)//reset lastDist so there won't be one frame of "REVERSE" appearing
            {
                lastDist = Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark2.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark2.transform.position.z), 2f)); //use pythagorean theorem to calculate distance that disregards y axis  

                lastDistMax = false;
            }

            if (Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark2.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark2.transform.position.z), 2f)) < lastDist)
            {

                lastDist = Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark2.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark2.transform.position.z), 2f));
                /////////////////////////////////////
                timeinReverse = 0;

                timenotReverse += Time.deltaTime;
                if (timenotReverse > 0.5)
                {
                    reverse = false;
                }
            }
            else if (Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark2.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark2.transform.position.z), 2f)) > lastDist)
            {
                Debug.Log("Reverse!");
                lastDist = Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark2.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark2.transform.position.z), 2f));
                /////////////////////////////////////
                timenotReverse = 0;

                timeinReverse += Time.deltaTime;

                if (timeinReverse > 2)
                {
                    reverse = true;
                }
            }


        }

        if (passedM2 == true) 
        {
            Debug.Log(lastDist);
            //  lastDistMax = false;
            if (lastDistMax == true)//reset lastDist so there won't be one frame of "REVERSE" appearing
            {
                lastDist = Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark2x.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark2x.transform.position.z), 2f)); 
                lastDistMax = false;
            }
            //lastDist = Vector3.Distance(this.transform.position, mark2.transform.position);
            if (Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark2x.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark2x.transform.position.z), 2f)) < lastDist)
            {
              
                lastDist = Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark2x.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark2x.transform.position.z), 2f));
                /////////////////////////////////////
                timeinReverse = 0;

                timenotReverse += Time.deltaTime;
                if (timenotReverse > 0.5)
                {
                    reverse = false;
                }
            }
            else if (Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark2x.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark2x.transform.position.z), 2f)) > lastDist)
            {
                Debug.Log("Reverse!");
                
                lastDist = Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark2x.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark2x.transform.position.z), 2f));
                /////////////////////////////////////
                timenotReverse = 0;

                timeinReverse += Time.deltaTime;

                if (timeinReverse > 2)
                {
                    reverse = true;
                }
            }
        

        }
        if (passedM2x == true)
        {
            Debug.Log(lastDist);
            //  lastDistMax = false;
            if (lastDistMax == true)//reset lastDist so there won't be one frame of "REVERSE" appearing
            {
                lastDist = Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark3.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark3.transform.position.z), 2f));
                lastDistMax = false;
            }
            //lastDist = Vector3.Distance(this.transform.position, mark2.transform.position);
            if (Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark3.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark3.transform.position.z), 2f)) < lastDist)
            {

                lastDist = Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark3.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark3.transform.position.z), 2f));
                /////////////////////////////////////
                timeinReverse = 0;

                timenotReverse += Time.deltaTime;
                if (timenotReverse > 0.5)
                {
                    reverse = false;
                }
            }
            else if (Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark3.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark3.transform.position.z), 2f)) > lastDist)
            {
                Debug.Log("Reverse!");

                lastDist = Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark3.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark3.transform.position.z), 2f));
                /////////////////////////////////////
                timenotReverse = 0;

                timeinReverse += Time.deltaTime;

                if (timeinReverse > 2)
                {
                    reverse = true;
                }
            }


        }

        if (passedM3 == true)
        {
            Debug.Log(lastDist);
            //  lastDistMax = false;
            if (lastDistMax == true)//reset lastDist so there won't be one frame of "REVERSE" appearing
            {
                lastDist = Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark1.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark1.transform.position.z), 2f));
                lastDistMax = false;
            }
            //lastDist = Vector3.Distance(this.transform.position, mark2.transform.position);
            if (Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark1.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark1.transform.position.z), 2f)) < lastDist)
            {

                lastDist = Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark1.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark1.transform.position.z), 2f));

                /////////////////////////////////////
                timeinReverse = 0;

                timenotReverse += Time.deltaTime;
                if (timenotReverse > 0.5)
                {
                    reverse = false;
                }
            }
            else if (Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark1.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark1.transform.position.z), 2f)) > lastDist)
            {
                Debug.Log("Reverse!");

                lastDist = Mathf.Sqrt(Mathf.Pow(Mathf.Abs(this.transform.position.x - mark1.transform.position.x), 2f) + Mathf.Pow(Mathf.Abs(this.transform.position.z - mark1.transform.position.z), 2f));
                /////////////////////////////////////
                timenotReverse = 0;

                timeinReverse += Time.deltaTime;

                if (timeinReverse > 2)
                {
                    reverse = true;
                }


        }

        //if (lastDistMax == true)
        //{
        //    lastDist = 100;
        //}
}
        if (reverse == true)
        {
          
                text.GetComponent<Text>().enabled = true;
                textBG.SetActive(true);
          

        }
        else if (reverse == false)
        {
            
                text.GetComponent<Text>().enabled = false;
                textBG.SetActive(false);
            
        
            //  Debug.Log(Vector3.Distance(this.transform.position, mark1.transform.position));
            //Debug.Log(Vector3.Distance(this.transform.position, mark2.transform.position));

        }


    }

   


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Cube1")
        {
            lastDistMax = true;
            passedM1 = true;
            passedM1x = false;
            passedM2 = false;
            passedM2x = false;
            passedM3 = false;
            Debug.Log("entered");
        }
        if (collision.gameObject.name == "Cube1x")
        {
            lastDistMax = true;
            passedM1x = true;
            passedM1 = false;
            passedM2 = false;
            passedM2x = false;
            passedM3 = false;
            Debug.Log("entered");
        }
        if (collision.gameObject.name == "Cube2")
        {
            lastDistMax = true;
            passedM2 = true;
            passedM1 = false;
            passedM3 = false;
            passedM2x = false;
            passedM1x = false;
            Debug.Log("entered");
        }
        if (collision.gameObject.name == "Cube2x")
        {
            lastDistMax = true;
            passedM2x = true;
            passedM1 = false;
            passedM2 = false;
            passedM1x = false;
            passedM3 = false;
            Debug.Log("entered");
        }

        if (collision.gameObject.name == "Cube3")
        {
            lastDistMax = true;
            passedM2 = false;
            passedM2x = false;
            passedM1x = false;
            passedM1 = false;
            passedM3 = true;
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
