using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berry : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Player_manager.banyak_berry++;
            Audio_manager.Instance.Play_SFX("berry");
            Destroy(gameObject);
        }

    }

}
