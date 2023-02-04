using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_awan_menu : MonoBehaviour
{
    public float scroll_speed_awan1;
    public GameObject awan1;

    void Update()
    {
        auto_scroll_awan1();
    }

    void auto_scroll_awan1()
    {
        Renderer rend = awan1.GetComponent<Renderer>();
        float offset = Time.time * (scroll_speed_awan1);
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }


}
