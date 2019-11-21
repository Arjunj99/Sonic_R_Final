using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Allow a GameObject with this script to query track types, angle of planes, and if it is still on the road.
/// </summary>
/// <author> Arjun Jaishankar </author>
/// <version> 11/21/2019 </version>
public class RoadCheck : MonoBehaviour {
    [Header("Ray Settings")]
    [SerializeField] private float trackTypeDistance = 3f; // Ray Distance of Track Check
    [SerializeField] private float normalReorientationDistance = 3f; // Ray Distance of Plane Check
    [SerializeField] private float onTrackDistance = 10f; // Ray Distance of Reverse Check
    private Turning turning;
    private Movement movement;
    private Vector3 planeNormal;

    // Start is called before the first frame update
    void Start() {
        // Road Check needs a reference to a Movement Script and Turning Script
        movement = gameObject.GetComponent<Movement>();
        turning = gameObject.GetComponent<Turning>();
    }

    // Update is called once per frame
    void Update() {
        // Checks Road for TrackType and sets speed accordingly
        Ray roadCheck = new Ray(this.transform.position, Vector3.down);
        RaycastHit roadTypeHit;
        Debug.DrawRay(this.transform.position, Vector3.down, Color.cyan, trackTypeDistance);

        if (Physics.Raycast(roadCheck, out roadTypeHit, trackTypeDistance) && roadTypeHit.collider.tag.Equals("Road")) {
            movement.currentSurfaceType = Movement.trackType.track;
        } else if (Physics.Raycast(roadCheck, out roadTypeHit, trackTypeDistance) && roadTypeHit.collider.tag.Equals("Sand")) {
            movement.currentSurfaceType = Movement.trackType.sand;
        } else if (Physics.Raycast(roadCheck, out roadTypeHit, trackTypeDistance) && roadTypeHit.collider.tag.Equals("Grass")) {
            movement.currentSurfaceType = Movement.trackType.grass;
        } else if (Physics.Raycast(roadCheck, out roadTypeHit, trackTypeDistance) && roadTypeHit.collider.tag.Equals("Water")) {
            movement.currentSurfaceType = Movement.trackType.water;
        }

        // Checks Road for Normal Vector and sets player X rotation accordingly
        Ray groundCheck = new Ray(this.transform.position, -this.transform.up);
        RaycastHit groundHit;
        Debug.DrawRay(this.transform.position, -this.transform.up, Color.green, normalReorientationDistance);

        if (Physics.Raycast(groundCheck, out groundHit, normalReorientationDistance) && groundHit.collider.gameObject.layer == 8) {
            planeNormal = Quaternion.ToEulerAngles(Quaternion.FromToRotation(Vector3.up, groundHit.normal)) * Mathf.Rad2Deg;
            turning.normalOrientation = planeNormal;
            Debug.Log(planeNormal);
        }

        // Checks to see if Player is above road and sets onRoad boolean accordingly
        Ray onRoadCheck = new Ray(this.transform.position, this.transform.forward - this.transform.up);
        RaycastHit onRoadHit;
        Debug.DrawRay(this.transform.position, this.transform.forward - this.transform.up, Color.green, onTrackDistance);

        if (Physics.Raycast(onRoadCheck, out onRoadHit, onTrackDistance) && onRoadHit.collider.gameObject.layer == 8) {
            // reverse.onRoad = true;
        } else {
            // reverse.onRoad = false;
        }
    }
}
