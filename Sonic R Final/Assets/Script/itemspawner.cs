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
    public GameObject ring10;
    public GameObject ring11;
    public GameObject ring12;
    public GameObject ring13;
    public GameObject ring14;
    public GameObject ring15;
    public GameObject ring16;
    public GameObject ring17;
    public GameObject ring18;
    public GameObject ring19;
    public GameObject ring20;
    public GameObject ring21;
    public GameObject ring22;
    public GameObject ring23;
    public GameObject ring24;
    public GameObject ring25;
    public GameObject ring26;
    public GameObject ring27;
    public GameObject ring28;
    public GameObject ring29;
    public GameObject ring30;
    public GameObject ring31;
    public GameObject ring32;
    public GameObject ring33;
    public GameObject ring34;
    public GameObject ring35;
    public GameObject ring36;
    public GameObject ring37;
    public GameObject ring38;
    public GameObject ring39;
    public GameObject ring40;
    public GameObject ring41;
    public GameObject ring42;
    public GameObject ring43;
    public GameObject ring44;
    public GameObject ring45;
    public GameObject ring46;
    public GameObject ring47;
    public GameObject ring48;
    public GameObject ring49;

    public GameObject ringx5;
    public GameObject ringx51;
    public GameObject ringx52;
    public GameObject ringx53;

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
    public Vector3 ringPos10;
    public Vector3 ringPos11;
    public Vector3 ringPos12;
    public Vector3 ringPos13;
    public Vector3 ringPos14;
    public Vector3 ringPos15;
    public Vector3 ringPos16;
    public Vector3 ringPos17;
    public Vector3 ringPos18;
    public Vector3 ringPos19;
    public Vector3 ringPos20;
    public Vector3 ringPos21;
    public Vector3 ringPos22;
    public Vector3 ringPos23;
    public Vector3 ringPos24;
    public Vector3 ringPos25;
    public Vector3 ringPos26;
    public Vector3 ringPos27;
    public Vector3 ringPos28;
    public Vector3 ringPos29;
    public Vector3 ringPos30;
    public Vector3 ringPos31;
    public Vector3 ringPos32;
    public Vector3 ringPos33;
    public Vector3 ringPos34;
    public Vector3 ringPos35;
    public Vector3 ringPos36;
    public Vector3 ringPos37;
    public Vector3 ringPos38;
    public Vector3 ringPos39;
    public Vector3 ringPos40;
    public Vector3 ringPos41;
    public Vector3 ringPos42;
    public Vector3 ringPos43;
    public Vector3 ringPos44;
    public Vector3 ringPos45;
    public Vector3 ringPos46;
    public Vector3 ringPos47;
    public Vector3 ringPos48;
    public Vector3 ringPos49;

    public Vector3 ringx5Pos;
    public Vector3 ringx5Pos1;
    public Vector3 ringx5Pos2;
    public Vector3 ringx5Pos3;

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
    public float ringTimer10;
    public float ringTimer11;
    public float ringTimer12;
    public float ringTimer13;
    public float ringTimer14;
    public float ringTimer15;
    public float ringTimer16;
    public float ringTimer17;
    public float ringTimer18;
    public float ringTimer19;
    public float ringTimer20;
    public float ringTimer21;
    public float ringTimer22;
    public float ringTimer23;
    public float ringTimer24;
    public float ringTimer25;
    public float ringTimer26;
    public float ringTimer27;
    public float ringTimer28;
    public float ringTimer29;
    public float ringTimer30;
    public float ringTimer31;
    public float ringTimer32;
    public float ringTimer33;
    public float ringTimer34;
    public float ringTimer35;
    public float ringTimer36;
    public float ringTimer37;
    public float ringTimer38;
    public float ringTimer39;
    public float ringTimer40;
    public float ringTimer41;
    public float ringTimer42;
    public float ringTimer43;
    public float ringTimer44;
    public float ringTimer45;
    public float ringTimer46;
    public float ringTimer47;
    public float ringTimer48;
    public float ringTimer49;
    
    public float ringx5Timer;
    public float ringx5Timer1;
    public float ringx5Timer2;
    public float ringx5Timer3;

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
    public bool ringGone10;
    public bool ringGone11;
    public bool ringGone12;
    public bool ringGone13;
    public bool ringGone14;
    public bool ringGone15;
    public bool ringGone16;
    public bool ringGone17;
    public bool ringGone18;
    public bool ringGone19;
    public bool ringGone20;
    public bool ringGone21;
    public bool ringGone22;
    public bool ringGone23;
    public bool ringGone24;
    public bool ringGone25;
    public bool ringGone26;
    public bool ringGone27;
    public bool ringGone28;
    public bool ringGone29;
    public bool ringGone30;
    public bool ringGone31;
    public bool ringGone32;
    public bool ringGone33;
    public bool ringGone34;
    public bool ringGone35;
    public bool ringGone36;
    public bool ringGone37;
    public bool ringGone38;
    public bool ringGone39;
    public bool ringGone40;
    public bool ringGone41;
    public bool ringGone42;
    public bool ringGone43;
    public bool ringGone44;
    public bool ringGone45;
    public bool ringGone46;
    public bool ringGone47;
    public bool ringGone48;
    public bool ringGone49;

    public bool ringx5Gone;
    public bool ringx5Gone1;
    public bool ringx5Gone2;
    public bool ringx5Gone3;

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
        ringx5Pos2 = ringx52.transform.position;
        ringx5Pos3 = ringx53.transform.position;

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
        ringPos10 = ring10.transform.position;
        ringPos11 = ring11.transform.position;
        ringPos12 = ring12.transform.position;
        ringPos13 = ring13.transform.position;
        ringPos14 = ring14.transform.position;
        ringPos15 = ring15.transform.position;
        ringPos16 = ring16.transform.position;
        ringPos17 = ring17.transform.position;
        ringPos18 = ring18.transform.position;
        ringPos19 = ring19.transform.position;
        ringPos20 = ring20.transform.position;
        ringPos21 = ring21.transform.position;
        ringPos22 = ring22.transform.position;
        ringPos23 = ring23.transform.position;
        ringPos24 = ring24.transform.position;
        ringPos25 = ring25.transform.position;
        ringPos26 = ring26.transform.position;
        ringPos27 = ring27.transform.position;
        ringPos28 = ring28.transform.position;
        ringPos29 = ring29.transform.position;
        ringPos30 = ring30.transform.position;
        ringPos31 = ring31.transform.position;
        ringPos32 = ring32.transform.position;
        ringPos33 = ring33.transform.position;
        ringPos34 = ring34.transform.position;
        ringPos35 = ring35.transform.position;
        ringPos36 = ring36.transform.position;
        ringPos37 = ring37.transform.position;
        ringPos38 = ring38.transform.position;
        ringPos39 = ring39.transform.position;
        ringPos40 = ring40.transform.position;
        ringPos41 = ring41.transform.position;
        ringPos42 = ring42.transform.position;
        ringPos43 = ring43.transform.position;
        ringPos44 = ring44.transform.position;
        ringPos45 = ring45.transform.position;
        ringPos46 = ring46.transform.position;
        ringPos47 = ring47.transform.position;
        ringPos48 = ring48.transform.position;
        ringPos49 = ring49.transform.position;
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
        if (ringx5Gone2 == true)
        {
            ringx5Timer2 += Time.deltaTime;
            if (ringx5Timer2 > spawnTime)
            {
                Instantiate(ringx52, ringx5Pos2, Quaternion.identity);
                ringx5Gone2 = false;
                ringx5Timer2 = 0;
            }
        }

        if (ringx5Gone3 == true)
        {
            ringx5Timer3 += Time.deltaTime;
            if (ringx5Timer3 > spawnTime)
            {
                Instantiate(ringx53, ringx5Pos3, Quaternion.identity);
                ringx5Gone3 = false;
                ringx5Timer3 = 0;
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
        if (ringGone10 == true)
        {
            ringTimer10 += Time.deltaTime;
            if (ringTimer10 > spawnTime)
            {
                Instantiate(ring10, ringPos10, Quaternion.identity);
                ringGone10 = false;
                ringTimer10 = 0;
            }
        }
        if (ringGone11 == true)
        {
            ringTimer11 += Time.deltaTime;
            if (ringTimer11 > spawnTime)
            {
                Instantiate(ring11, ringPos11, Quaternion.identity);
                ringGone11 = false;
                ringTimer11 = 0;
            }
        }
        if (ringGone12 == true)
        {
            ringTimer12 += Time.deltaTime;
            if (ringTimer12 > spawnTime)
            {
                Instantiate(ring12, ringPos12, Quaternion.identity);
                ringGone12 = false;
                ringTimer12 = 0;
            }
        }
        if (ringGone13 == true)
        {
            ringTimer13 += Time.deltaTime;
            if (ringTimer13 > spawnTime)
            {
                Instantiate(ring13, ringPos13, Quaternion.identity);
                ringGone13 = false;
                ringTimer13 = 0;
            }
        }
        if (ringGone14 == true)
        {
            ringTimer14 += Time.deltaTime;
            if (ringTimer14 > spawnTime)
            {
                Instantiate(ring14, ringPos14, Quaternion.identity);
                ringGone14 = false;
                ringTimer14 = 0;
            }
        }
        if (ringGone15 == true)
        {
            ringTimer15 += Time.deltaTime;
            if (ringTimer15 > spawnTime)
            {
                Instantiate(ring15, ringPos15, Quaternion.identity);
                ringGone15 = false;
                ringTimer15 = 0;
            }
        }
        if (ringGone16 == true)
        {
            ringTimer16 += Time.deltaTime;
            if (ringTimer16 > spawnTime)
            {
                Instantiate(ring16, ringPos16, Quaternion.identity);
                ringGone16 = false;
                ringTimer16 = 0;
            }
        }
        if (ringGone17 == true)
        {
            ringTimer17 += Time.deltaTime;
            if (ringTimer17 > spawnTime)
            {
                Instantiate(ring17, ringPos17, Quaternion.identity);
                ringGone17 = false;
                ringTimer17 = 0;
            }
        }
        if (ringGone18 == true)
        {
            ringTimer18 += Time.deltaTime;
            if (ringTimer18 > spawnTime)
            {
                Instantiate(ring18, ringPos18, Quaternion.identity);
                ringGone18 = false;
                ringTimer18 = 0;
            }
        }
        if (ringGone19 == true)
        {
            ringTimer19 += Time.deltaTime;
            if (ringTimer19 > spawnTime)
            {
                Instantiate(ring19, ringPos19, Quaternion.identity);
                ringGone19 = false;
                ringTimer19 = 0;
            }
        }
        if (ringGone20 == true)
        {
            ringTimer20 += Time.deltaTime;
            if (ringTimer20 > spawnTime)
            {
                Instantiate(ring20, ringPos20, Quaternion.identity);
                ringGone20 = false;
                ringTimer20 = 0;
            }
        }
        if (ringGone21 == true)
        {
            ringTimer21 += Time.deltaTime;
            if (ringTimer21 > spawnTime)
            {
                Instantiate(ring21, ringPos21, Quaternion.identity);
                ringGone21 = false;
                ringTimer21 = 0;
            }
        }
        if (ringGone22 == true)
        {
            ringTimer22 += Time.deltaTime;
            if (ringTimer22 > spawnTime)
            {
                Instantiate(ring22, ringPos22, Quaternion.identity);
                ringGone22 = false;
                ringTimer22 = 0;
            }
        }
        if (ringGone23 == true)
        {
            ringTimer23 += Time.deltaTime;
            if (ringTimer23 > spawnTime)
            {
                Instantiate(ring23, ringPos23, Quaternion.identity);
                ringGone23 = false;
                ringTimer23 = 0;
            }
        }
        if (ringGone24 == true)
        {
            ringTimer24 += Time.deltaTime;
            if (ringTimer24 > spawnTime)
            {
                Instantiate(ring24, ringPos24, Quaternion.identity);
                ringGone24 = false;
                ringTimer24 = 0;
            }
        }
        if (ringGone25 == true)
        {
            ringTimer25 += Time.deltaTime;
            if (ringTimer25 > spawnTime)
            {
                Instantiate(ring25, ringPos25, Quaternion.identity);
                ringGone25 = false;
                ringTimer25 = 0;
            }
        }
        if (ringGone26 == true)
        {
            ringTimer26 += Time.deltaTime;
            if (ringTimer26 > spawnTime)
            {
                Instantiate(ring26, ringPos26, Quaternion.identity);
                ringGone26 = false;
                ringTimer26 = 0;
            }
        }
        if (ringGone27 == true)
        {
            ringTimer27 += Time.deltaTime;
            if (ringTimer27 > spawnTime)
            {
                Instantiate(ring27, ringPos27, Quaternion.identity);
                ringGone27 = false;
                ringTimer27 = 0;
            }
        }
        if (ringGone28 == true)
        {
            ringTimer28 += Time.deltaTime;
            if (ringTimer28 > spawnTime)
            {
                Instantiate(ring28, ringPos28, Quaternion.identity);
                ringGone28 = false;
                ringTimer28 = 0;
            }
        }
        if (ringGone29 == true)
        {
            ringTimer29 += Time.deltaTime;
            if (ringTimer29 > spawnTime)
            {
                Instantiate(ring29, ringPos29, Quaternion.identity);
                ringGone29 = false;
                ringTimer29 = 0;
            }
        }
        if (ringGone30 == true)
        {
            ringTimer30 += Time.deltaTime;
            if (ringTimer30 > spawnTime)
            {
                Instantiate(ring30, ringPos30, Quaternion.identity);
                ringGone30 = false;
                ringTimer30 = 0;
            }
        }
        if (ringGone31 == true)
        {
            ringTimer31 += Time.deltaTime;
            if (ringTimer31 > spawnTime)
            {
                Instantiate(ring31, ringPos31, Quaternion.identity);
                ringGone31 = false;
                ringTimer31 = 0;
            }
        }
        if (ringGone32 == true)
        {
            ringTimer32 += Time.deltaTime;
            if (ringTimer32 > spawnTime)
            {
                Instantiate(ring32, ringPos32, Quaternion.identity);
                ringGone32 = false;
                ringTimer32 = 0;
            }
        }
        if (ringGone33 == true)
        {
            ringTimer33 += Time.deltaTime;
            if (ringTimer33 > spawnTime)
            {
                Instantiate(ring33, ringPos33, Quaternion.identity);
                ringGone33 = false;
                ringTimer33 = 0;
            }
        }
        if (ringGone34 == true)
        {
            ringTimer34 += Time.deltaTime;
            if (ringTimer34 > spawnTime)
            {
                Instantiate(ring34, ringPos34, Quaternion.identity);
                ringGone34 = false;
                ringTimer34 = 0;
            }
        }
        if (ringGone35 == true)
        {
            ringTimer35 += Time.deltaTime;
            if (ringTimer35 > spawnTime)
            {
                Instantiate(ring35, ringPos35, Quaternion.identity);
                ringGone35 = false;
                ringTimer35 = 0;
            }
        }
        if (ringGone36 == true)
        {
            ringTimer36 += Time.deltaTime;
            if (ringTimer36 > spawnTime)
            {
                Instantiate(ring36, ringPos36, Quaternion.identity);
                ringGone36 = false;
                ringTimer36 = 0;
            }
        }
        if (ringGone37 == true)
        {
            ringTimer37 += Time.deltaTime;
            if (ringTimer37 > spawnTime)
            {
                Instantiate(ring37, ringPos37, Quaternion.identity);
                ringGone37 = false;
                ringTimer37 = 0;
            }
        }
        if (ringGone38 == true)
        {
            ringTimer38 += Time.deltaTime;
            if (ringTimer18 > spawnTime)
            {
                Instantiate(ring38, ringPos38, Quaternion.identity);
                ringGone38 = false;
                ringTimer38 = 0;
            }
        }
        if (ringGone39 == true)
        {
            ringTimer39 += Time.deltaTime;
            if (ringTimer39 > spawnTime)
            {
                Instantiate(ring39, ringPos39, Quaternion.identity);
                ringGone39 = false;
                ringTimer39 = 0;
            }
        }
        if (ringGone40 == true)
        {
            ringTimer40 += Time.deltaTime;
            if (ringTimer40 > spawnTime)
            {
                Instantiate(ring40, ringPos40, Quaternion.identity);
                ringGone40 = false;
                ringTimer40 = 0;
            }
        }
        if (ringGone41 == true)
        {
            ringTimer41 += Time.deltaTime;
            if (ringTimer41 > spawnTime)
            {
                Instantiate(ring41, ringPos41, Quaternion.identity);
                ringGone41 = false;
                ringTimer41 = 0;
            }
        }
        if (ringGone42 == true)
        {
            ringTimer42 += Time.deltaTime;
            if (ringTimer42 > spawnTime)
            {
                Instantiate(ring42, ringPos42, Quaternion.identity);
                ringGone42 = false;
                ringTimer42 = 0;
            }
        }
        if (ringGone43 == true)
        {
            ringTimer43 += Time.deltaTime;
            if (ringTimer43 > spawnTime)
            {
                Instantiate(ring43, ringPos43, Quaternion.identity);
                ringGone43 = false;
                ringTimer43 = 0;
            }
        }
        if (ringGone44 == true)
        {
            ringTimer44 += Time.deltaTime;
            if (ringTimer44 > spawnTime)
            {
                Instantiate(ring44, ringPos44, Quaternion.identity);
                ringGone44 = false;
                ringTimer44 = 0;
            }
        }
        if (ringGone45 == true)
        {
            ringTimer45 += Time.deltaTime;
            if (ringTimer45 > spawnTime)
            {
                Instantiate(ring45, ringPos45, Quaternion.identity);
                ringGone45 = false;
                ringTimer45 = 0;
            }
        }
        if (ringGone46 == true)
        {
            ringTimer46 += Time.deltaTime;
            if (ringTimer46 > spawnTime)
            {
                Instantiate(ring46, ringPos46, Quaternion.identity);
                ringGone46 = false;
                ringTimer46 = 0;
            }
        }
        if (ringGone47 == true)
        {
            ringTimer47 += Time.deltaTime;
            if (ringTimer47 > spawnTime)
            {
                Instantiate(ring47, ringPos47, Quaternion.identity);
                ringGone47 = false;
                ringTimer47 = 0;
            }
        }
        if (ringGone48 == true)
        {
            ringTimer48 += Time.deltaTime;
            if (ringTimer48 > spawnTime)
            {
                Instantiate(ring48, ringPos48, Quaternion.identity);
                ringGone48 = false;
                ringTimer48 = 0;
            }
        }
        if (ringGone49 == true)
        {
            ringTimer49 += Time.deltaTime;
            if (ringTimer49 > spawnTime)
            {
                Instantiate(ring49, ringPos49, Quaternion.identity);
                ringGone49 = false;
                ringTimer49 = 0;
            }
        }
    }
}
