using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public GameObject poin_tele;
    public GameObject poin_dasar;
    private GameObject player;


    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Tele());
            if (Player_manager.banyak_darah == 0)
            {
                StartCoroutine(Dasar());
            }
            StopCoroutine(Dasar());
        }
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
       
    //}
    IEnumerator Tele()
    {
        yield return new WaitForSeconds(1);
        player.transform.position = new Vector2(poin_tele.transform.position.x, poin_tele.transform.position.y);
    }
    IEnumerator Dasar()
    {
        yield return new WaitForSeconds(1);
        player.transform.position = new Vector2(poin_dasar.transform.position.x, poin_dasar.transform.position.y);
    }
}
