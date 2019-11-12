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
            movement.currentSurfaceType = Movement.trackType.track;
            // boat.SetCurrentSpeed(boat.GetCurrentSpeed() + 0.2f);
        } else if (Physics.Raycast(roadCheck, out hit, 3f) && hit.collider.tag.Equals("Sand")) {
            movement.currentSurfaceType = Movement.trackType.sand;
        } else if (Physics.Raycast(roadCheck, out hit, 3f) && hit.collider.tag.Equals("Grass")) {
            movement.currentSurfaceType = Movement.trackType.grass;
        } else if (Physics.Raycast(roadCheck, out hit, 3f) && hit.collider.tag.Equals("Water")) {
            movement.currentSurfaceType = Movement.trackType.water;
        }
    }
}
