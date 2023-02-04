using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax_BG : MonoBehaviour
{
    private Vector2 currentPosition, LastPosition, PositionDifference;
    private bool parallaxNow;
    public float speed;

    void FixedUpdate()
    {
        if (parallaxNow == true)
        {
            DetectCameraMovment();
            transform.Translate(new Vector3(PositionDifference.x, PositionDifference.y, 0) * speed * Time.fixedDeltaTime, Space.World);
        }
    }

    void DetectCameraMovment()
    {
        currentPosition = new Vector2(Camera.main.transform.position.x, Camera.main.transform.position.y);
        if (currentPosition == LastPosition)
        {
            PositionDifference = Vector2.zero;
        }
        else
        {
            PositionDifference = currentPosition - LastPosition;
        }
        LastPosition = currentPosition;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "MainCamera")
        {
            LastPosition = currentPosition = new Vector2(Camera.main.transform.position.x, Camera.main.transform.position.y);
            parallaxNow = true;
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.tag == "MainCamera")
        {
            parallaxNow = true;
        }
    }


    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "MainCamera")
        {
            PositionDifference = Vector2.zero;
            parallaxNow = false;
        }
    }
}
