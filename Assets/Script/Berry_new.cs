using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berry_new : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Player_manager.banyak_berry++;
            Player_manager.banyak_berry_convert_nyawa++;//
            PlayerPrefs.SetInt("berry_res",Player_manager.banyak_berry);
            Audio_manager.Instance.Play_SFX("berry");
            Destroy(gameObject);
        }
    }
    
}
