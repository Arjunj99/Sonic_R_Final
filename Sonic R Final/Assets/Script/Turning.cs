using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Allow a GameObject with this script to turn based on direction inputs. Also correct its orientation based on the plane it is on.
/// </summary>
/// <author> Arjun Jaishankar </author>
/// <version> 11/21/2019 </version>
public class Turning : MonoBehaviour {
    [Header("Turn Settings Settings")]
    [SerializeField] private float turnIncrement;
    [SerializeField] private float turnMaxSpeed;
    [SerializeField] private float turnLerp;
    [HideInInspector] public float turnSpeed;
    [HideInInspector] public Vector3 normalOrientation;
    [HideInInspector] public float rotation;
    public float turnModifier = 1f;
    public AnimationCurve rotationCurve;
    private float currentTime;
    public float timePeriod;
    public Vector3 normalVector;

    [Header("Button Settings")]
     public KeyCode leftKey;
     public KeyCode rightKey;

    void Start() {
        rotation = gameObject.transform.rotation.y;
        currentTime = 0.5f;
    }

    // Update is called once per frame
    void Update() {
        if ((Input.GetKey(rightKey) && currentTime < 1f)) {
            currentTime += Time.deltaTime / timePeriod;
        } else if (Input.GetKey(rightKey) && currentTime >= 1f) {
            currentTime = 1f;
        }

        if ((Input.GetKey(leftKey) && currentTime > 0f)) {
            currentTime -= Time.deltaTime / timePeriod;
        } else if (Input.GetKey(leftKey) && currentTime <= 0f) {
            currentTime = 0f;
        }

        rotation += rotationCurve.Evaluate(currentTime) * turnModifier;

        gameObject.transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, Quaternion.Euler(normalOrientation + normalVector*rotation), 1f);

        currentTime = Mathf.Lerp(currentTime, 0.5f, Time.deltaTime * 3);
    }
}
