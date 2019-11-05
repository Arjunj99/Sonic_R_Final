using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public bool onTrack;
    public float velocity;
    public float maxVelocity;

    private Rigidbody rb;
    // public float 

    // Start is called before the first frame update
    void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if (onTrack) {
            maxVelocity = 100f;
        } else {
            maxVelocity = 25f;
        }

        


        if (Input.GetKey(KeyCode.W) && velocity < maxVelocity) {
            velocity += 2;
        } else if (velocity > 0) {
            velocity--;
        }

        if (Input.GetKey(KeyCode.D)) {
            gameObject.transform.Rotate(new Vector3(0,1,0));
        } else if (Input.GetKey(KeyCode.A)) {
            gameObject.transform.Rotate(new Vector3(0,-1,0));
        }

        gameObject.transform.position += transform.forward * velocity / 500;
    }
}
