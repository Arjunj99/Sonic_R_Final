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
      
        zoom = 60+player.GetComponent<Movement>().currentVelocity/2;
        zoom = Mathf.Clamp(zoom, 60f, 70f);
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
