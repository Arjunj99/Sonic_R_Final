using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadCheck : MonoBehaviour {
    private Movement movement;

    // Start is called before the first frame update
    void Start() {
        movement = gameObject.GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update() {
        Ray roadCheck = new Ray(this.transform.position, Vector3.down);
        RaycastHit hit;
        Debug.DrawRay(this.transform.position, Vector3.down, Color.cyan, 10f);

        if (Physics.Raycast(roadCheck, out hit, 3f) && hit.collider.tag.Equals("Road")) {
            movement.onTrack = true;
            Debug.Log("On Road");
            // boat.SetCurrentSpeed(boat.GetCurrentSpeed() + 0.2f);
        } else {
            movement.onTrack = false;
        }
    }
}
