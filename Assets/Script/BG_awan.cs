using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_awan : MonoBehaviour
{
    public float scroll_speed_awan1;
    public float scroll_speed_awan2;
    public float scroll_speed_gunung;
    public float scroll_speed_burung;
    public GameObject awan1;
    public GameObject gunung;
    public GameObject awan2;
    public GameObject burung;
    public Transform vcam;
    
    void Update()
    {
        auto_scroll_awan1();
        auto_scroll_awan2();
        scroll_gunung();
        auto_scroll_burung();
    }
 
    void auto_scroll_awan1()
    {
        Renderer rend = awan1.GetComponent<Renderer>();
        float offset = Time.time * (scroll_speed_awan1);
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
    void auto_scroll_awan2()
    {
        Renderer rend = awan2.GetComponent<Renderer>();
        float offset = Time.time * (scroll_speed_awan2);
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }


    void scroll_gunung()
    {
        Renderer rend = gunung.GetComponent<Renderer>();
        rend.material.SetTextureOffset("_MainTex", new Vector2(vcam.position.x * scroll_speed_gunung, 0));
    }

    void auto_scroll_burung()
    {
        Renderer rend = burung.GetComponent<Renderer>();
        float offset = Time.time * (scroll_speed_burung);
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
