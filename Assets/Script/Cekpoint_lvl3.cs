using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cekpoint_lvl3 : MonoBehaviour
{
    public static Vector2 cekpoint = new Vector2(-22, 1);
    private void Awake()
    {

        GameObject.FindGameObjectWithTag("Player").transform.position = cekpoint;
    }

    public void home()
    {
        cekpoint = new Vector2(-22, 1);
    }
}
