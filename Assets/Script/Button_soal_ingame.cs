using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_soal_ingame : MonoBehaviour
{
    public GameObject soal_ingame;
    public string jawaban;

    public Soal_manager_ingame soal_m_ingame;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            //Player_manager.banyak_berry++;
            //Sprite currentjawaban = gameObject.GetComponent<SpriteRenderer>().sprite;
            //jawaban = gameObject.GetComponent<SpriteRenderer>().sprite.name;

            soal_m_ingame.Button_jawaban();
            //Debug.Log(currentjawaban.name);



            soal_ingame.SetActive(false);
        }

    }
}
