using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    public float deadZone;

    public int p1totalTime;
    public int p1roundOneTime;
    public int p1roundTwoTime;
    public int p1roundThreeTime;
    public int p1roundFourTime;
    public int p1roundFiveTime;

    public int p2totalTime;
    public int p2roundOneTime;
    public int p2roundTwoTime;
    public int p2roundThreeTime;
    public int p2roundFourTime;
    public int p2roundFiveTime;

    // Start is called before the first frame update
    void Awake() {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        }
        else {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
