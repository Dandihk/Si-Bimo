using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active_platform_geser : MonoBehaviour
{
    public Platform_geser plat;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        plat.tunggu = false;   
    }
}
