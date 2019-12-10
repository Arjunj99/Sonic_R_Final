using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Allow a GameObject with this script to pick up GameObjects with Tags {Ring, Token5, Token10, Token20, Aqua, SpeedBoost}.
/// </summary>
/// <author> Arjun Jaishankar </author>
/// <version> 11/21/2019 </version>
public class PickUp : MonoBehaviour {
    public Text text; // Text used to display current score.
    public CharacterMovement characterMovement;
    public Movement movement; // Reference to a movement script in the current GameObject. PICK UP NEEDS A MOVEMENT SCRIPT ON THE SAME OBJECT.
    [HideInInspector] public int rings = 0; // This GameObject's current Score.

    // Start is called before the first frame update
    void Start() {
        characterMovement = gameObject.GetComponent<CharacterMovement>();
        text = GameObject.Find("Score Text").GetComponent<Text>();
        movement = gameObject.GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update() {
        // text.text = "Score: " + score.ToString();
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Ring") { // If GameObject picks up a ring, add 1 to the score.
            characterMovement.rings++;
            Destroy(other.gameObject);
        } else if (other.tag == "Token5") { // If GameObject picks up a Token 5, add 5 to the score.
            characterMovement.rings += 5;
            Destroy(other.gameObject);
        } else if (other.tag == "Token10") { // If GameObject picks up a Token 10, add 10 to the score.
            characterMovement.rings += 10;
            Destroy(other.gameObject);
        } else if (other.tag == "Token20") { // If GameObject picks up a Token 20, add 20 to the score.
            characterMovement.rings += 20;
            Destroy(other.gameObject);
        } else if (other.tag == "SpeedBoost") { // If GameObject picks up a Speed Boost, add 100 to the current Velocity.
            // movement.currentVelocity += 100f;
            Destroy(other.gameObject);
        } else if (other.tag == "Aqua") { // If GameObject picks up an Aqua Token, make the player able to run on water.
            if (other.gameObject.name == "Waterwalk")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().waterGone = true;
            }
            else if (other.gameObject.name == "Waterwalk 1")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().waterGone1 = true;
            }

            characterMovement.StartCoroutine(characterMovement.walkOnWater());
            Destroy(other.gameObject);
        }
    }
}
