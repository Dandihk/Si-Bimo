using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_kontak_emeny : MonoBehaviour
{
    public Player_manager manager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            Player_manager.banyak_darah--;
            if (Player_manager.banyak_darah==0)
            {
                manager.game_over();
                //Destroy(gameObject);
            } else {
                StartCoroutine(Sakit());
                Audio_manager.Instance.Play_SFX("damage");
            }
            
            
        }
        //StopCoroutine(Sakit());
        
    }


    IEnumerator Sakit()
    {
        Physics2D.IgnoreLayerCollision(6, 7);
        GetComponent<Animator>().SetLayerWeight(1, 1);
        yield return new WaitForSeconds(2);
        Physics2D.IgnoreLayerCollision(6, 7, false);
        GetComponent<Animator>().SetLayerWeight(1, 0);


    }
}
