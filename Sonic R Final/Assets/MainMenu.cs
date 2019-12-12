using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject pauseScreen;
    private bool pauseScreenActive=true;
    public GameObject controlScreen;


    public Text[] buttons;
    public int currentSelect;
    public Color selected;
    public Color deselected;
    public GameObject pointer;
    private Vector3 pointerpos;

    public string player1input;
    private bool cantMove = false;

    private void Start()
    {
    }

    void Update()
    {
        selectColor();
        selection();
    }

   

  

    void selectColor()
    {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (i == currentSelect)
                {
                    buttons[i].color = selected;
                }
                else
                {
                    buttons[i].color = deselected;
                }
            }
    }

    void selection()
    {
        if (pauseScreenActive)
        {
            if ((Input.GetAxis(player1input) > GameManager.instance.deadZone) && !cantMove)
            {
                if (currentSelect > 0)
                {
                    cantMove = true;
                    currentSelect--;
                    pointer.transform.position += new Vector3(0, buttons[1].gameObject.transform.position.y-buttons[2].gameObject.transform.position.y, 0);
                }
            }
            else if ((Input.GetAxis(player1input) < -GameManager.instance.deadZone) && !cantMove)
            {
                if (currentSelect < buttons.Length - 1)
                {
                    cantMove = true;
                    currentSelect++;
                    pointer.transform.position += new Vector3(0, buttons[2].gameObject.transform.position.y-buttons[1].gameObject.transform.position.y, 0);
                }
            }
            else if ((Input.GetAxis(player1input) < GameManager.instance.deadZone) &&
                     (Input.GetAxis(player1input) > -GameManager.instance.deadZone))
            {
                cantMove = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            if (pauseScreenActive)
            {
                if (currentSelect == 0)
                {
                    SceneManager.LoadScene(1);
                }
                else if (currentSelect == 1)
                {
                    pauseScreen.SetActive(false);
                    controlScreen.SetActive(true);
                    pauseScreenActive = false;
                }
                else if (currentSelect == 2)
                {
                    Application.Quit();
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            if ((!pauseScreenActive))
            {
                pauseScreen.SetActive(true);
                controlScreen.SetActive(false);
                pauseScreenActive = true;
            }
        }
    }
}
