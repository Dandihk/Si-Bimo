using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tunggu_on_off : MonoBehaviour
{

    public GameObject platform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (platform.activeInHierarchy == false)
        {
            platform.transform.GetComponent<Platform_geser>().tunggu = false;
        }
    }
}
