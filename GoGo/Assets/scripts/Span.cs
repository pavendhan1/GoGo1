using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Span : MonoBehaviour
{
    public GameObject obstacklePreferb;
    public Vector3 spanpos = new Vector3(25, 0, 0);
    private float startdelay = 2;
    private float repeaterate = 2;
    private player playerst;
    
    // Start is called before the first frame update
    void Start()
    {
        playerst = GameObject.Find("player").GetComponent<player>();
        InvokeRepeating("SpawnObstackle", startdelay, repeaterate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstackle()
    {
        if (playerst.gameover == false)
        {
            Instantiate(obstacklePreferb, spanpos, obstacklePreferb.transform.rotation);
        }
    }
}
