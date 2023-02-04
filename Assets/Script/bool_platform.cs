using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bool_platform : MonoBehaviour
{
    Platform_geser geser;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag=="MainCamera")
        {
            geser.tunggu = false;
        }
    }
}
