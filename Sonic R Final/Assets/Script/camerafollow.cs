using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{

    public Transform player;
    public Vector3 upVector;
  //  public Vector3 leftVector;
  //  public Vector3 rightVector;

  //  public Vector3 oldRotation;
   // public Vector3 newRotation;

   // public Vector3 oldPosition;
   // public Vector3 newPosition;

    public bool left;

    // public Vector3 currentAngle;
    // public Vector3 targetAngle;

    //public float turnSpeed = 4.0f;

    Vector3 offsetVector = new Vector3(0,1,-4);

    Vector3 lerpDestination;
    // Start is called before the first frame update
    void Start()
    {
        

       // oldRotation = player.transform.rotation.eulerAngles;
     // oldPosition = player.transform.position;
    }


    // Update is called once per frame
    void FixedUpdate()
    {

        lerpDestination = player.position + offsetVector;
        Debug.Log(offsetVector);
       
        // newPosition = player.transform.position;
        transform.position = Vector3.Lerp(transform.position, lerpDestination, 0.5f);
         //transform.position = player.TransformPoint(offsetVector);
        transform.LookAt(player.position + upVector);//if only look at player it will be at center of screen
/* 
        

          if (oldPosition != newPosition) { 
       
        if (Input.GetKey(KeyCode.A))
        {
           left = true;
        }
        else
        {
         left = false;
         this.transform.position = player.transform.position + new Vector3(0, 1, -4);
       }
        oldPosition = newPosition;
        if (left == true) 
           { 
       this.transform.position = player.transform.position + new Vector3(1, 1, -4);
          }
        else
          {
              this.transform.position = Vector3.Lerp(newPosition, player.position+offsetVector, 0.2f);
         }
           newRotation = player.transform.rotation.eulerAngles;
            newPosition = player.transform.position;


            if (newRotation != oldRotation)
            { 



            oldRotation = newRotation;
            oldPosition = newPosition;

            }
            */



        /* if (player.transform.rotation.eulerAngles.y > oldRotation.y)
          {
              transform.localEulerAngles = new Vector3(0, -15, 0);
              Debug.Log("right");
              oldRotation = player.transform.rotation.eulerAngles;
          }
          else if (player.transform.rotation.eulerAngles.y < oldRotation.y)
          {
              transform.localEulerAngles = new Vector3(0, 15, 0);
              /* Quaternion target = Quaternion.Euler(0, -15, 0);
               transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 5);

              Debug.Log("left");
              oldRotation = player.transform.rotation.eulerAngles;
          }
          else if (player.transform.rotation.eulerAngles.y == oldRotation.y)
          {
              transform.localEulerAngles = new Vector3(0, 0, 0);
              Debug.Log("0");
              oldRotation = player.transform.rotation.eulerAngles;

          }

   */

        // Vector3 newpos = player.position + offsetVector;
        //this.transform.position = target.position + offsetVector;
        //this.transform.position = newpos;

        //transform.forward = player.transform.forward;
        //this.transform.position = Vector3.Lerp(this.transform.position, newpos, 0.2f); //using lerp

        //this.transform.position = Vector3.MoveTowards(this.transform.position, newpos, 0.01f); //smoother transform

        /* Vector3 moveVector = this.transform.position = newpos;
         moveVector *= 0.75f;
         newpos += moveVector;

         this.transform.position = newpos;
         */
        //  transform.rotation= RotateAround(player.position, Vector3.up, Time.deltaTime);
        // transform.rotation = player.transform.rotation;







    }





}
