using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScreen : MonoBehaviour
{
    public GameObject pauseScreen;
    public GameObject timer;
    public bool paused;

    public Text[] buttons;
    public int currentSelect;
    public Color selected;
    public Color deselected;

    public string player1input;
    public string player2input;
    private bool cantMove = false;

    void Start()
    {
        
    }

   
    void Update()
    {
        Pause();
        selectColor();
        selection();
    }

    void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button9))
        {
            if (pauseScreen.activeSelf==false)
            {
                pauseScreen.SetActive(true);
                timer.SetActive(false);
                paused = true;

                Time.timeScale = 0;
                currentSelect = 0;
            }
            else
            {
                pauseScreen.SetActive(false);
                timer.SetActive(true);
                paused = false;

                Time.timeScale = 1;
            }
        }
    }

    void selectColor()
    {
        if (paused)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (i==currentSelect)
                {
                    buttons[i].color = selected;
                }
                else
                {
                    buttons[i].color = deselected;
                }
            }
        }
    }

    void selection()
    {
       
        if ((Input.GetAxis(player1input)>GameManager.instance.deadZone) && !cantMove)
        {
            cantMove = true;
            
        }else if ((Input.GetAxis(player1input) < -GameManager.instance.deadZone) && !cantMove)
        {
            cantMove = true;
            Debug.Log("movedown");
        }else if ((Input.GetAxis(player1input) < GameManager.instance.deadZone) &&(Input.GetAxis(player1input) > -GameManager.instance.deadZone))
        {
            cantMove = false;
            Debug.Log("canMove");
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            if (currentSelect==0)
            {
                pauseScreen.SetActive(false);
                               timer.SetActive(true);
                               paused = false;
                               Time.timeScale = 1; 
            }
        }
    }
}
