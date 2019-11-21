using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour {
    public Text text;
    public Movement movement;
    private int score;

    // Start is called before the first frame update
    void Start() {
        text = GameObject.Find("Score Text").GetComponent<Text>();
        movement = gameObject.GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update() {
        text.text = "Score: " + score.ToString();
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Ring") {
            score++;
            Destroy(other.gameObject);
        } else if (other.tag == "Token5") {
            score += 5;
            Destroy(other.gameObject);
        } else if (other.tag == "Token10") {
            score += 10;
            Destroy(other.gameObject);
        } else if (other.tag == "Token20") {
            score += 20;
            Destroy(other.gameObject);
        } else if (other.tag == "SpeedBoost") {
            movement.currentVelocity += 100f;
            Destroy(other.gameObject);
        } else if (other.tag == "Aqua") {
            movement.surfaceSpeeds[(int) Movement.trackType.water] = 100f;
            Destroy(other.gameObject);
        }
    }
}
