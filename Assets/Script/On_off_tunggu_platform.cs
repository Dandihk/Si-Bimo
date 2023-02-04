using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_off_tunggu_platform : MonoBehaviour
{
    public GameObject panel_tunggu;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Platform_geser")
        {
            panel_tunggu.SetActive(false);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Platform_geser")
        {
            panel_tunggu.SetActive(true);
        }
    }

}
