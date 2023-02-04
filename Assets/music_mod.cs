using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_mod : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Audio_manager.Instance.Play_SFX("mod");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Audio_manager.Instance.stop_SFX("mod");
        }
    }
}
