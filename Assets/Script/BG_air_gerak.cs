using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_air_gerak : MonoBehaviour
{
    public float scroll_speed_air;
    public GameObject[] air;
    //public GameObject air2;
    //public GameObject air3;
    //public GameObject air4;

    void Update()
    {
        auto_scroll_air();
        //auto_scroll_air2();
        //auto_scroll_air3();
        //auto_scroll_air4();
    }

    void auto_scroll_air()
    {
        for (int i = 0; i < air.Length; i++)
        {
            Renderer rend = air[i].GetComponent<Renderer>();
            float offset = Time.time * (scroll_speed_air);
            rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        }
    }
   
}

//public float scroll_speed_air1;
//public GameObject air1;
//public GameObject air2;
//public GameObject air3;
//public GameObject air4;

//void Update()
//{
//    auto_scroll_air1();
//    auto_scroll_air2();
//    auto_scroll_air3();
//    auto_scroll_air4();
//}

//void auto_scroll_air1()
//{
//    Renderer rend = air1.GetComponent<Renderer>();
//    float offset = Time.time * (scroll_speed_air1);
//    rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
//}
//void auto_scroll_air2()
//{
//    Renderer rend = air2.GetComponent<Renderer>();
//    float offset = Time.time * (scroll_speed_air1);
//    rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
//}
//void auto_scroll_air3()
//{
//    Renderer rend = air3.GetComponent<Renderer>();
//    float offset = Time.time * (scroll_speed_air1);
//    rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
//}
//void auto_scroll_air4()
//{
//    Renderer rend = air4.GetComponent<Renderer>();
//    float offset = Time.time * (scroll_speed_air1);
//    rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));

//}