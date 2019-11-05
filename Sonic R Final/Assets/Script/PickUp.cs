using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour {
    public Text text;
    private int score;

    // Start is called before the first frame update
    void Start() {
        text = GameObject.Find("Score Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update() {
        text.text = "Score: " + score.ToString();
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Ring") {
            score++;
            Destroy(other.gameObject);
        }
    }
}
