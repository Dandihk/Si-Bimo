using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cekpoint3 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Cekpoint_lvl3.cekpoint = transform.position;

        }
    }
}
