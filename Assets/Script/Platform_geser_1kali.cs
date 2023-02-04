using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_geser_1kali : MonoBehaviour
{
    public float speed;
    public int startpoint;
    public Transform[] point;

    bool masuk;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = point[startpoint].position;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (masuk)
        {
            transform.position = Vector2.MoveTowards(transform.position, point[1].position, speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (transform.position.y < collision.transform.position.y)
        {
            collision.transform.SetParent(transform);
        }

        masuk = true;
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        
        collision.transform.SetParent(null);
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);
    }
}
