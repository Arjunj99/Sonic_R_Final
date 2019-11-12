using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public Vector3 cameraPosition;
    public Vector3 cameraRotation;
    public Vector3 offset;
    public GameObject player;

    public GameObject hinge;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraPosition = player.transform.position + offset;

        hinge.transform.rotation = Quaternion.Slerp(hinge.transform.rotation, Quaternion.Euler(cameraRotation), 0.8f * Time.deltaTime);
        hinge.transform.position = Vector3.Slerp(hinge.transform.position, cameraPosition, 0.8f * Time.deltaTime);

        if (Input.GetKey(KeyCode.D)) {
            cameraRotation.y += 0.2f;
        } else if (Input.GetKey(KeyCode.A)) {
            cameraRotation.y -= 0.2f;
        }
    }
}
