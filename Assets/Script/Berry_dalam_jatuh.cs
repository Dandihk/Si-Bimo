using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berry_dalam_jatuh : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Player_manager.banyak_berry++;
            Player_manager.banyak_berry_convert_nyawa++;
            PlayerPrefs.SetInt("berry_res", Player_manager.banyak_berry);
            Audio_manager.Instance.Play_SFX("berry");
            Destroy(gameObject);
            //Berry_jatuh.berry_jatuh--;
        }
        if (collision.transform.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
