using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class replay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey) {
            GameManager.instance.p1totalTime = 0;
            GameManager.instance.p1roundOneTime = 0;
            GameManager.instance.p1roundTwoTime = 0;
            GameManager.instance.p1roundThreeTime = 0;
            GameManager.instance.p1roundFourTime = 0;
            GameManager.instance.p1roundFiveTime = 0;
            GameManager.instance.p2totalTime = 0;
            GameManager.instance.p2roundOneTime =0;
            GameManager.instance.p2roundTwoTime = 0;
            GameManager.instance.p2roundThreeTime = 0;
            GameManager.instance.p2roundFourTime = 0;
            GameManager.instance.p2roundFiveTime = 0;
            SceneManager.LoadScene("MainScene");
        }
    }
}
