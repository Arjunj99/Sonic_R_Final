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
        if (other.tag == "Ring")
        { // If GameObject picks up a ring, add 1 to the score.
            if (other.gameObject.name == "Ring" || other.gameObject.name == "Ring(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone = true;
            }
            else if (other.gameObject.name == "Ring 1" || other.gameObject.name == "Ring 1(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone1 = true;
            }
            else if (other.gameObject.name == "Ring 2" || other.gameObject.name == "Ring 2(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone2 = true;
            }
            else if (other.gameObject.name == "Ring 3" || other.gameObject.name == "Ring 3(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone3 = true;
            }
            else if (other.gameObject.name == "Ring 4" || other.gameObject.name == "Ring 4(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone4 = true;
            }
            if (other.gameObject.name == "Ring 5" || other.gameObject.name == "Ring 5(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone5 = true;
            }
            else if (other.gameObject.name == "Ring 6" || other.gameObject.name == "Ring 6(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone6 = true;
            }
            else if (other.gameObject.name == "Ring 7" || other.gameObject.name == "Ring 7(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone7 = true;
            }
            else if (other.gameObject.name == "Ring 8" || other.gameObject.name == "Ring 8(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone8 = true;    
            }
            else if (other.gameObject.name == "Ring 9" || other.gameObject.name == "Ring 9(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone9 = true;
            }
            characterMovement.rings++;
            Destroy(other.gameObject);
        }

        else if (other.tag == "Token5")
        { // If GameObject picks up a Token 5, add 5 to the score.
            if (other.gameObject.name == "Ring 5x" || other.gameObject.name == "Ring 5x(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringx5Gone = true;
            }
            else if (other.gameObject.name == "Ring 5x 1" || other.gameObject.name == "Ring 5x 1(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringx5Gone1 = true;
            }
            characterMovement.rings += 5;
            Destroy(other.gameObject);
        }
        else if (other.tag == "Token10")
        { // If GameObject picks up a Token 10, add 10 to the score.
            if (other.gameObject.name == "Ring 10x" || other.gameObject.name == "Ring 10x(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringx10Gone = true;
            }
            else if (other.gameObject.name == "Ring 10x 1" || other.gameObject.name == "Ring 10x 1(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringx10Gone1 = true;
            }
            characterMovement.rings += 10;
            Destroy(other.gameObject);
        }

        else if (other.tag == "Token20")
        { // If GameObject picks up a Token 20, add 20 to the score.
            GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringx20Gone = true;
            characterMovement.rings += 20;
            Destroy(other.gameObject);
        }

        else if (other.tag == "SpeedBoost")
        { // If GameObject picks up a Speed Boost, add 100 to the current Velocity.
            // movement.currentVelocity += 100f;
            Destroy(other.gameObject);
        }

        else if (other.tag == "Aqua")
        { // If GameObject picks up an Aqua Token, make the player able to run on water.
            if (other.gameObject.name == "Waterwalk"|| other.gameObject.name == "Waterwalk(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().waterGone = true;
            }
            else if (other.gameObject.name == "Waterwalk 1" || other.gameObject.name == "Waterwalk 1(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().waterGone1 = true;
            }

            characterMovement.StartCoroutine(characterMovement.walkOnWater());
            Destroy(other.gameObject);
        }
    }
}
