using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatebg : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatwith;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatwith = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    { 
         if(transform.position.x<startPos.x-repeatwith)
    {
            transform.position = startPos;
    }
}
}
