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
    public GameObject ring1;
    public GameObject ring2;
    public GameObject ring3;
    public GameObject ring4;
    public GameObject ring5;
    public GameObject ring6;
    public GameObject ring7;
    public GameObject ring8;
    public GameObject ring9;

    public GameObject ringx5;
    public GameObject ringx51;

    public GameObject ringx10;
    public GameObject ringx101;

    public GameObject ringx20;
    /////////////////////////////////////////////////
    public Vector3 squidPos;
    public Vector3 confusePos;
    public Vector3 waterPos;
    public Vector3 waterPos1;

    public Vector3 ringPos;
    public Vector3 ringPos1;
    public Vector3 ringPos2;
    public Vector3 ringPos3;
    public Vector3 ringPos4;
    public Vector3 ringPos5;
    public Vector3 ringPos6;
    public Vector3 ringPos7;
    public Vector3 ringPos8;
    public Vector3 ringPos9;
    
    public Vector3 ringx5Pos;
    public Vector3 ringx5Pos1;

    public Vector3 ringx10Pos;
    public Vector3 ringx10Pos1;

    public Vector3 ringx20Pos;
    /////////////////////////////////////////////////
    public float squidTimer;
    public float confuseTimer;
    public float waterTimer;
    public float waterTimer1;
    public float ringTimer;
    public float ringTimer1;
    public float ringTimer2;
    public float ringTimer3;
    public float ringTimer4;
    public float ringTimer5;
    public float ringTimer6;
    public float ringTimer7;
    public float ringTimer8;
    public float ringTimer9;

    public float ringx5Timer;
    public float ringx5Timer1;

    public float ringx10Timer;
    public float ringx10Timer1;

    public float ringx20Timer;
    /////////////////////////////////////////////////
    public bool squidGone;
    public bool confuseGone;
    public bool waterGone;
    public bool waterGone1;

    public bool ringGone;
    public bool ringGone1;
    public bool ringGone2;
    public bool ringGone3;
    public bool ringGone4;
    public bool ringGone5;
    public bool ringGone6;
    public bool ringGone7;
    public bool ringGone8;
    public bool ringGone9;

    public bool ringx5Gone;
    public bool ringx5Gone1;

    public bool ringx10Gone;
    public bool ringx10Gone1;

    public bool ringx20Gone;


    public float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        squidPos = squid.transform.position;
        confusePos = confuse.transform.position;
        waterPos = waterRun.transform.position;
        waterPos1 = waterRun1.transform.position;

        ringx5Pos = ringx5.transform.position;
        ringx5Pos1 = ringx51.transform.position;

        ringx10Pos = ringx10.transform.position;
        ringx10Pos1 = ringx101.transform.position;

        ringx20Pos = ringx20.transform.position;

        ringPos = ring.transform.position;
        ringPos1 = ring1.transform.position;
        ringPos2 = ring2.transform.position;
        ringPos3 = ring3.transform.position;
        ringPos4 = ring4.transform.position;
        ringPos5 = ring5.transform.position;
        ringPos6 = ring6.transform.position;
        ringPos7 = ring7.transform.position;
        ringPos8 = ring8.transform.position;
        ringPos9 = ring9.transform.position;

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
        if (ringx5Gone == true)
        {
            ringx5Timer += Time.deltaTime;
            if (ringx5Timer > spawnTime)
            {
                Instantiate(ringx5, ringx5Pos, Quaternion.identity);
                ringx5Gone = false;
                ringx5Timer = 0;
            }
        }

        if (ringx5Gone1 == true)
        {
            ringx5Timer1 += Time.deltaTime;
            if (ringx5Timer1 > spawnTime)
            {
                Instantiate(ringx51, ringx5Pos1, Quaternion.identity);
                ringx5Gone1 = false;
                ringx5Timer1 = 0;
            }
        }

        if (ringx10Gone == true)
        {
            ringx10Timer += Time.deltaTime;
            if (ringx10Timer > spawnTime)
            {
                Instantiate(ringx10, ringx10Pos, Quaternion.identity);
                ringx10Gone = false;
                ringx10Timer = 0;
            }
        }
        if (ringx10Gone1 == true)
        {
            ringx10Timer1 += Time.deltaTime;
            if (ringx10Timer1 > spawnTime)
            {
                Instantiate(ringx101, ringx10Pos1, Quaternion.identity);
                ringx10Gone1 = false;
                ringx10Timer1 = 0;
            }
        }
        if (ringx20Gone == true)
        {
            ringx20Timer += Time.deltaTime;
            if (ringx20Timer > spawnTime)
            {
                Instantiate(ringx20, ringx20Pos, Quaternion.identity);
                ringx20Gone = false;
                ringx20Timer = 0;
            }
        }
        if (ringGone == true)
        {
            ringTimer += Time.deltaTime;
            if (ringTimer > spawnTime)
            {
                Instantiate(ring, ringPos, Quaternion.identity);
                ringGone = false;
                ringTimer = 0;
            }
        }
        if (ringGone1 == true)
        {
            ringTimer1 += Time.deltaTime;
            if (ringTimer1 > spawnTime)
            {
                Instantiate(ring1, ringPos1, Quaternion.identity);
                ringGone1 = false;
                ringTimer1 = 0;
            }
        }
        if (ringGone2 == true)
        {
            ringTimer2 += Time.deltaTime;
            if (ringTimer2 > spawnTime)
            {
                Instantiate(ring2, ringPos2, Quaternion.identity);
                ringGone2 = false;
                ringTimer2 = 0;
            }
        }
        if (ringGone3 == true)
        {
            ringTimer3 += Time.deltaTime;
            if (ringTimer3 > spawnTime)
            {
                Instantiate(ring3, ringPos3, Quaternion.identity);
                ringGone3 = false;
                ringTimer3 = 0;
            }
        }
        if (ringGone4 == true)
        {
            ringTimer4 += Time.deltaTime;
            if (ringTimer4 > spawnTime)
            {
                Instantiate(ring4, ringPos4, Quaternion.identity);
                ringGone4 = false;
                ringTimer4 = 0;
            }
        }
        if (ringGone5 == true)
        {
            ringTimer5 += Time.deltaTime;
            if (ringTimer5 > spawnTime)
            {
                Instantiate(ring5, ringPos5, Quaternion.identity);
                ringGone5 = false;
                ringTimer5 = 0;
            }
        }
        if (ringGone6 == true)
        {
            ringTimer6 += Time.deltaTime;
            if (ringTimer6 > spawnTime)
            {
                Instantiate(ring6, ringPos6, Quaternion.identity);
                ringGone6 = false;
                ringTimer6 = 0;
            }
        }
        if (ringGone7 == true)
        {
            ringTimer7 += Time.deltaTime;
            if (ringTimer7 > spawnTime)
            {
                Instantiate(ring7, ringPos7, Quaternion.identity);
                ringGone7 = false;
                ringTimer7 = 0;
            }
        }
        if (ringGone8 == true)
        {
            ringTimer8 += Time.deltaTime;
            if (ringTimer8 > spawnTime)
            {
                Instantiate(ring8, ringPos8, Quaternion.identity);
                ringGone8 = false;
                ringTimer8 = 0;
            }
        }
        if (ringGone9 == true)
        {
            ringTimer9 += Time.deltaTime;
            if (ringTimer9 > spawnTime)
            {
                Instantiate(ring9, ringPos9, Quaternion.identity);
                ringGone9 = false;
                ringTimer9 = 0;
            }
        }



    }
}
