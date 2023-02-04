using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cekpoint_lvl1 : MonoBehaviour
{
    public static Vector2 cekpoint = new Vector2(-5, 1);
    private void Awake()
    {

        GameObject.FindGameObjectWithTag("Player").transform.position = cekpoint;
    }

    public void home()
    {
        cekpoint = new Vector2(-5, 1);
    }
}
