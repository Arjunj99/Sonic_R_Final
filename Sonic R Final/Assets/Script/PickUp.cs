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
            if (other.gameObject.name == "Ring 10" || other.gameObject.name == "Ring 10(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone10 = true;
            }
            else if (other.gameObject.name == "Ring 11" || other.gameObject.name == "Ring 11(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone11 = true;
            }
            else if (other.gameObject.name == "Ring 12" || other.gameObject.name == "Ring 12(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone12 = true;
            }
            else if (other.gameObject.name == "Ring 13" || other.gameObject.name == "Ring 13(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone13 = true;
            }
            else if (other.gameObject.name == "Ring 14" || other.gameObject.name == "Ring 14(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone14 = true;
            }
            if (other.gameObject.name == "Ring 15" || other.gameObject.name == "Ring 15(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone15 = true;
            }
            else if (other.gameObject.name == "Ring 16" || other.gameObject.name == "Ring 16(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone16 = true;
            }
            else if (other.gameObject.name == "Ring 17" || other.gameObject.name == "Ring 17(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone17 = true;
            }
            else if (other.gameObject.name == "Ring 18" || other.gameObject.name == "Ring 18(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone18 = true;
            }
            else if (other.gameObject.name == "Ring 19" || other.gameObject.name == "Ring 19(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone19 = true;
            }
            if (other.gameObject.name == "Ring 20" || other.gameObject.name == "Ring 20(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone20 = true;
            }
            else if (other.gameObject.name == "Ring 21" || other.gameObject.name == "Ring 21(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone21 = true;
            }
            else if (other.gameObject.name == "Ring 22" || other.gameObject.name == "Ring 22(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone22 = true;
            }
            else if (other.gameObject.name == "Ring 23" || other.gameObject.name == "Ring 23(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone23 = true;
            }
            else if (other.gameObject.name == "Ring 24" || other.gameObject.name == "Ring 24(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone24 = true;
            }
            if (other.gameObject.name == "Ring 25" || other.gameObject.name == "Ring 25(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone25 = true;
            }
            else if (other.gameObject.name == "Ring 26" || other.gameObject.name == "Ring 26(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone26 = true;
            }
            else if (other.gameObject.name == "Ring 27" || other.gameObject.name == "Ring 27(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone27 = true;
            }
            else if (other.gameObject.name == "Ring 28" || other.gameObject.name == "Ring 28(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone28 = true;
            }
            else if (other.gameObject.name == "Ring 29" || other.gameObject.name == "Ring 29(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone29 = true;
            }
            if (other.gameObject.name == "Ring 30" || other.gameObject.name == "Ring 30(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone30 = true;
            }
            else if (other.gameObject.name == "Ring 31" || other.gameObject.name == "Ring 31(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone31 = true;
            }
            else if (other.gameObject.name == "Ring 32" || other.gameObject.name == "Ring 32(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone32 = true;
            }
            else if (other.gameObject.name == "Ring 33" || other.gameObject.name == "Ring 33(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone33 = true;
            }
            else if (other.gameObject.name == "Ring 34" || other.gameObject.name == "Ring 34(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone34 = true;
            }
            if (other.gameObject.name == "Ring 35" || other.gameObject.name == "Ring 35(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone35 = true;
            }
            else if (other.gameObject.name == "Ring 36" || other.gameObject.name == "Ring 36(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone36 = true;
            }
            else if (other.gameObject.name == "Ring 37" || other.gameObject.name == "Ring 37(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone37 = true;
            }
            else if (other.gameObject.name == "Ring 38" || other.gameObject.name == "Ring 38(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone38 = true;
            }
            else if (other.gameObject.name == "Ring 39" || other.gameObject.name == "Ring 39(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone39 = true;
            }
            if (other.gameObject.name == "Ring 40" || other.gameObject.name == "Ring 40(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone40 = true;
            }
            else if (other.gameObject.name == "Ring 41" || other.gameObject.name == "Ring 41(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone41 = true;
            }
            else if (other.gameObject.name == "Ring 42" || other.gameObject.name == "Ring 42(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone42 = true;
            }
            else if (other.gameObject.name == "Ring 43" || other.gameObject.name == "Ring 43(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone43 = true;
            }
            else if (other.gameObject.name == "Ring 44" || other.gameObject.name == "Ring 44(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone44 = true;
            }
            if (other.gameObject.name == "Ring 45" || other.gameObject.name == "Ring 45(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone45 = true;
            }
            else if (other.gameObject.name == "Ring 46" || other.gameObject.name == "Ring 46(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone46 = true;
            }
            else if (other.gameObject.name == "Ring 47" || other.gameObject.name == "Ring 47(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone47 = true;
            }
            else if (other.gameObject.name == "Ring 48" || other.gameObject.name == "Ring 48(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone48 = true;
            }
            else if (other.gameObject.name == "Ring 49" || other.gameObject.name == "Ring 49(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringGone49 = true;
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
            else if (other.gameObject.name == "Ring 5x 2" || other.gameObject.name == "Ring 5x 2(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringx5Gone2 = true;
            }
            else if (other.gameObject.name == "Ring 5x 3" || other.gameObject.name == "Ring 5x 3(Clone)")
            {
                GameObject.Find("ItemSpawner").GetComponent<itemspawner>().ringx5Gone3 = true;
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
