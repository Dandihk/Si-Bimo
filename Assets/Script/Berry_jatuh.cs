using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berry_jatuh : MonoBehaviour
{
    public Rigidbody2D RB_berry1;
    //public Rigidbody2D RB_berry2;
    //public Rigidbody2D RB_berry3;
    //[SerializeField] public static int berry_jatuh=3;
    public GameObject obj;
    //public GameObject berrry;

    private void Start()
    {
        //RB_berry.bodyType = RigidbodyType2D.Kinematic;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            RB_berry1.bodyType = RigidbodyType2D.Dynamic;
        }

    }
    private void Update()
    {
        collider_off();
    }
    void collider_off()
    {
        if ( RB_berry1 == null)
        {
            obj.SetActive(false);
        }
    }
  

}

//public Rigidbody2D RB_berry1;
//public Rigidbody2D RB_berry2;
//public Rigidbody2D RB_berry3;
//[SerializeField] public static int berry_jatuh = 3;
//public GameObject obj;
////public GameObject berrry;

//private void Start()
//{
//    //RB_berry.bodyType = RigidbodyType2D.Kinematic;

//}
//private void OnTriggerEnter2D(Collider2D collision)
//{
//    if (collision.transform.tag == "Player")
//    {
//        RB_berry1.bodyType = RigidbodyType2D.Dynamic;
//        RB_berry2.bodyType = RigidbodyType2D.Dynamic;
//        RB_berry3.bodyType = RigidbodyType2D.Dynamic;
//    }

//}
//private void Update()
//{
//    dis_coll();
//}
//void dis_coll()
//{
//    if (berry_jatuh == 0)
//    {
//        obj.SetActive(false);
//    }
//}