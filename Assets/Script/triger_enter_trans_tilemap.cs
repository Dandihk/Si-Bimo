using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class triger_enter_trans_tilemap : MonoBehaviour
{
    public Tilemap layer_depan_tilemap_trans;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            layer_depan_tilemap_trans.GetComponent<Tilemap>().color = new Color(255, 255, 255, 0.5f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            layer_depan_tilemap_trans.GetComponent<Tilemap>().color = new Color(255, 255, 255, 1f);
        }
    }
}
