using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemspawner : MonoBehaviour
{
    public GameObject squid;
    public GameObject confuse;
    public GameObject waterRun;
    public GameObject ring;

    public Vector3 squidPos;
    public Vector3 confusePos;
    public Vector3 waterPos;
    public Vector3 ringPos;

    public float squidTimer;
    public float confuseTimer;
    public float waterTimer;
    public float ringTimer;

    public bool squidGone;
    public bool confuseGone;
    public bool waterGone;
    public bool ringGone;

    public float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        squidPos = squid.transform.position;
        confusePos = confuse.transform.position;
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
    }
}
