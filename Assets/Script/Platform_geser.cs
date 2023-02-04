using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_geser : MonoBehaviour
{
    public float speed;
    public int startpoint;
    public Transform[] point;
    public bool tunggu=false;
    private int i;
    

    //public GameObject bimo;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = point[startpoint].position;
        tunggu = false;
    }

    
    
    // Update is called once per frame
    void Update()
    {

        


        if (!tunggu==true)//
        {
            move(); 
        }

        
    }
    private void Awake()
    {
        //StopCoroutine(tungguin()); //
        tunggu = false;
    }

    private void move()
    {
        
        if (Vector2.Distance(transform.position, point[i].position) < 0.02f)
        {

            i++;
            if (i == point.Length)
            {
                i = 0;
            }
            //tunggu = true; /// bak_tak taruh corutine
            StartCoroutine(tungguin());
            
        }

        transform.position = Vector2.MoveTowards(transform.position, point[i].position, speed * Time.deltaTime);


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (transform.position.y < collision.transform.position.y)
        {
            collision.transform.SetParent(transform);
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
        //DontDestroyOnLoad(GameObject.FindWithTag("Player"));
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);
    }

    IEnumerator tungguin()
    {
        tunggu = true;//
        yield return new WaitForSeconds(1f);

        
        //transform.position = Vector2.MoveTowards(transform.position, point[i].position, speed * Time.deltaTime);
        tunggu = false;
    }

}

// bak
//public float speed;
//public int startpoint;
//public Transform[] point;


//private int i;

////public GameObject bimo;

//// Start is called before the first frame update
//void Start()
//{
//    transform.position = point[startpoint].position;

//}

//// Update is called once per frame
//void Update()
//{

//    if (Vector2.Distance(transform.position, point[i].position) < 0.02f)
//    {

//        i++;
//        if (i == point.Length)
//        {
//            i = 0;
//        }

//    }

//    transform.position = Vector2.MoveTowards(transform.position, point[i].position, speed * Time.deltaTime);
//}

//private void OnCollisionEnter2D(Collision2D collision)
//{
//    if (transform.position.y < collision.transform.position.y)
//    {
//        collision.transform.SetParent(transform);
//    }

//}
//private void OnCollisionExit2D(Collision2D collision)
//{
//    collision.transform.SetParent(null);
//    //DontDestroyOnLoad(GameObject.FindWithTag("Player"));
//}
//private void OnCollisionStay2D(Collision2D collision)
//{
//    collision.transform.SetParent(transform);
//}

//IEnumerator tunggu()
//{


//    yield return new WaitForSeconds(1f);
//    //transform.position = Vector2.MoveTowards(transform.position, point[i].position, speed * Time.deltaTime);
//    i++;
//    if (i == point.Length)
//    {
//        i = 0;
//    }
//}

