using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraturn : MonoBehaviour
{
    public bool left=true;
    public bool center = false;
    public bool right = true;

    public int turnspeed1;
    public int turnspeed2;


   // public Vector3 curPos;
   // public Vector3 lastPos;

    //public Vector3 rotate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //curPos = this.transform.position;
        //  Debug.Log(this.transform.eulerAngles.y);
        //  Debug.Log(this.transform.localRotation.y);
        if (Input.GetKey(KeyCode.A))
        {
            center = false;
            if (left == true)
            {
               // if(curPos!=lastPos)
                if (this.transform.localRotation.y < 0.10)
                {
                    transform.Rotate(new Vector3(0, 1, 0), turnspeed1 * Time.deltaTime);
                   


                }
                else if (this.transform.localRotation.y > 0.10)
                {
                    left = false;
                }
            }
            
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            center = true;
            Debug.Log("1");
      
        }
        if (Input.GetKey(KeyCode.D))
        {
            center = false;
            if (left == true)
            {
                if (this.transform.localRotation.y > -0.10)
                {
                     transform.Rotate(new Vector3(0, -1, 0), turnspeed1 * Time.deltaTime);

                   // transform.rotation = Quaternion.Lerp(this.transform.localRotation, Quaternion.Euler(transform.rotation.x, 1f, transform.rotation.z), Time.deltaTime * turnspeed1);

                }
                else if (this.transform.localRotation.y > -0.10)
                {
                    left = false;
                }
            }

        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            center = true;
            Debug.Log("1");

        }



        if (center == true)
        {
            if (this.transform.localRotation.y > 0)
            {
                transform.Rotate(new Vector3(0, -1, 0), turnspeed2 * Time.deltaTime);
                left = true;
                right = true;
            }
            if (this.transform.localRotation.y < 0)
            {
                transform.Rotate(new Vector3(0, 1, 0), turnspeed2 * Time.deltaTime);
                left = true;
                right = true;
            }
        }


    }
    
}
