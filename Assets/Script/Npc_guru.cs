using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc_guru : MonoBehaviour
{
    public GameObject popup;
    Player_control controls;
    public GameObject pop_soal;

    //public Animator anim_popup;
    public Soal_manager_boss soal_manager_boss;
    //public waktu_per_soal Waktu_per_soal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            //StartCoroutine(popup_in());
            //popup.SetActive(true);
            controls = new Player_control();
            controls.Enable();
            controls.Move.Enter.performed += context =>
            {
                GetComponent<BoxCollider2D>().enabled = false;
                pop_soal.SetActive(true);
                popup.SetActive(false);
                soal_manager_boss.mulai();
                //Waktu_per_soal.Start_waktu();
            };
        }

    }

    //IEnumerator popup_in()
    //{
    //    popup.SetActive(true);
    //    yield return new WaitForSeconds(1f);
    //    anim_popup.SetTrigger("popup_stay");

    //}
    //IEnumerator popup_out()
    //{  
    //    anim_popup.SetTrigger("popup_out");
    //    yield return new WaitForSeconds(1f);
    //    popup.SetActive(false);

    //}

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            //StartCoroutine(popup_out());
            //popup.SetActive(false);
            controls.Disable();
            pop_soal.SetActive(false);
        }
    }
}
