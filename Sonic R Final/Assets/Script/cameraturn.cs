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

    private KeyCode rightKey;
    private KeyCode leftKey;
    
    public CharacterMovement movementscript;


    public Vector2 inputAxis;
    public float deadZone;
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
        inputAxis = movementscript.inputAxis;
        deadZone = movementscript.deadZone;

        if (inputAxis.x<-deadZone)
        {
            Debug.Log("1");
            center = false;
            if (left == true)
            {
               // if(curPos!=lastPos)
                if (this.transform.localRotation.y < 0.10) 
                {
                    transform.Rotate(new Vector3(0, 1, 0), turnspeed1 * Time.deltaTime); //if the player is turning left, rotate camera to the right
                   


                }
                else if (this.transform.localRotation.y > 0.10)
                {
                    left = false;
                }
            }
            
        }

        if (inputAxis.x>-deadZone&&inputAxis.x<deadZone)
        {
            center = true;
          //  Debug.Log("1");
      
        }
        if (inputAxis.x>deadZone)
        {
            //Debug.Log("2");
            center = false;
            if (right == true)
            {
                if (this.transform.localRotation.y > -0.10)
                {
                     transform.Rotate(new Vector3(0, -1, 0), turnspeed1 * Time.deltaTime); //if the player is turning right, rotate camera to the left

                    // transform.rotation = Quaternion.Lerp(this.transform.localRotation, Quaternion.Euler(transform.rotation.x, 1f, transform.rotation.z), Time.deltaTime * turnspeed1);

                }
                else if (this.transform.localRotation.y < -0.10)
                {
                    right = false;
                }
            }

        }

        if (inputAxis.x < deadZone && inputAxis.x > -deadZone)
        {
            center = true;
          //  Debug.Log("1");

        }



        if (center == true)  
        {
            if (this.transform.localRotation.y > 0) //turns the camera back to center after releasing left and right
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
