using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jamur_bouncy : MonoBehaviour
{
    public Animator anim_bouncy;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.transform.tag == "Player")
        {
            anim_bouncy.SetTrigger("on_enter");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            anim_bouncy.SetTrigger("on_exit");
        }
        
    }
}
