using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_laba_enter : MonoBehaviour
{
    public Animator anim_laba;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            StartCoroutine(laba_enter());
        }
    }

    IEnumerator laba_enter()
    {
        anim_laba.SetTrigger("laba_turun");
        yield return new WaitForSeconds(3);
        anim_laba.SetTrigger("laba_idle");
    }
}
