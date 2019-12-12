using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerazoom : MonoBehaviour
{
    public GameObject player;
    public float zoom;


    // Use this for initialization
    void Start()
    {
      
    }

    void Update()
    {
      
        zoom = 50+player.GetComponent<CharacterMovement>().forwardT*10; //zoom the camera according to player speed by increasing camera's FOV.
        zoom = Mathf.Clamp(zoom, 50f, 60f); //limit FOV between 50 and 60
        GetComponent<Camera>().fieldOfView = zoom;

        /*
        Debug.Log("Velocity:"); 
        Debug.Log(player.GetComponent<Movement>().velocity);
        Debug.Log("FOV:");
        Debug.Log(zoom);

    */

        //serliazeddfield
        //hideinspector
        //header
    }

        
}
