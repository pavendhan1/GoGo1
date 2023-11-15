using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{
    private float Speed = 30;
    private player playerst;
    private float leftbound = -10;
    // Start is called before the first frame update
    void Start()
    {
        playerst = GameObject.Find("player").GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    { 
        if(playerst.gameover==false)
        {
        transform.Translate(Vector3.left* Time.deltaTime* Speed);
        }
        if (transform.position.x < leftbound && gameObject.CompareTag("obstackle")) 
        {
            Destroy(gameObject);
        }
        
    }
}
