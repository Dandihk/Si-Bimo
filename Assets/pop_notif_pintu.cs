using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pop_notif_pintu : MonoBehaviour
{
    public GameObject pop_pintu;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            pop_pintu.SetActive(true);
        }
            
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        pop_pintu.SetActive(false);
    }
}
