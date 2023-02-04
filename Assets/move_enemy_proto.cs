using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_enemy_proto : MonoBehaviour
{
    public float speed;
    public int startpoint;
    public Transform[] point;


    private int i;

    //public GameObject bimo;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = point[startpoint].position;

    }

    // Update is called once per frame
    void Update()
    {

        if (Vector2.Distance(transform.position, point[i].position) < 0.02f)
        {

            i++;
            if (i == point.Length)
            {
                i = 0;
            }

        }

        transform.position = Vector2.MoveTowards(transform.position, point[i].position, speed * Time.deltaTime);
    }


}
