using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemspawner : MonoBehaviour
{
    public GameObject squid;
    public GameObject confuse;
    public GameObject waterRun;
    public GameObject waterRun1;
    public GameObject ring;
    public GameObject ringx5;
    public GameObject ringx10;
    public GameObject ringx20;
    /////////////////////////////////////////////////
    public Vector3 squidPos;
    public Vector3 confusePos;
    public Vector3 waterPos;
    public Vector3 waterPos1;
    public Vector3 ringPos;
    public Vector3 ringx5Pos;
    public Vector3 ringx10Pos;
    public Vector3 ringx20Pos;
    /////////////////////////////////////////////////
    public float squidTimer;
    public float confuseTimer;
    public float waterTimer;
    public float waterTimer1;
    public float ringTimer;
    public float ringx5Timer;
    public float ringx10Timer;
    public float ringx20Timer;
    /////////////////////////////////////////////////
    public bool squidGone;
    public bool confuseGone;
    public bool waterGone;
    public bool waterGone1;
    public bool ringGone;
    public bool ringx5Gone;
    public bool ringx10Gone;
    public bool ringx20Gone;


    public float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        squidPos = squid.transform.position;
        confusePos = confuse.transform.position;
        waterPos = waterRun.transform.position;
        waterPos1 = waterRun1.transform.position;
       
    }
        
    // Update is called once per frame
    void Update()
    {
       
        if (squidGone == true)
        {
            squidTimer += Time.deltaTime;
            if (squidTimer > spawnTime)
            {
                Instantiate(squid, squidPos, Quaternion.identity);
                squidGone = false;
                squidTimer = 0;
            }
        }
        if (confuseGone == true)
        {
            confuseTimer += Time.deltaTime;
            if (confuseTimer > spawnTime)
            {
                Instantiate(confuse, confusePos, Quaternion.identity);
                confuseGone = false;
                confuseTimer = 0;
            }
        }
        if (waterGone == true)
        {
            waterTimer += Time.deltaTime;
            if (waterTimer > spawnTime)
            {
                Instantiate(waterRun, waterPos, Quaternion.identity);
                waterGone = false;
                waterTimer = 0;
            }
        }
        if (waterGone1 == true)
        {
            waterTimer1 += Time.deltaTime;
            if (waterTimer1 > spawnTime)
            {
                Instantiate(waterRun1, waterPos1, Quaternion.identity);
                waterGone1 = false;
                waterTimer1 = 0;
            }
        }
       
    }
}
