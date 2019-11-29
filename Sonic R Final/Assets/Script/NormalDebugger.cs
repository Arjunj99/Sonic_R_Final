using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalDebugger : MonoBehaviour
{
    public Quaternion planeNormal;
    float rotation = 0;
    // Start is called before the first frame update
    RaycastHit groundHit;
    void Start()
    {
        Ray groundCheck = new Ray(this.transform.position, -this.transform.up);
        
        


        Debug.DrawRay(this.transform.position, -this.transform.up, Color.green, 2f);

        if (Physics.Raycast(groundCheck, out groundHit, 2f)) {
            planeNormal = Quaternion.FromToRotation(this.transform.up, groundHit.normal);
            this.transform.rotation = planeNormal;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) {
            rotation += 5f;
        }
        rotation = 1f;

        Ray groundCheck = new Ray(this.transform.position, -this.transform.up);

        if (Physics.Raycast(groundCheck, out groundHit, 2f)) {
            planeNormal = Quaternion.FromToRotation(this.transform.up, groundHit.normal);
            this.transform.rotation = planeNormal;
        }

        // this.transform.RotateAround(this.transform.position, this.transform.up, rotation);



        
        //this.transform.Rotate(this.transform.up*rotation);
        //this.transform.rotation= Quaternion.Euler(this.transform.rotation.eulerAngles+groundHit.normal*rotation);

    }
}
