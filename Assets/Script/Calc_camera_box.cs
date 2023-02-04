using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calc_camera_box : MonoBehaviour
{
    private Camera cam;
    private BoxCollider2D cambox;
    private float sizeX, sizeY, ratio;

    void Start()
    {
        cam = GetComponent<Camera>();
        cambox = GetComponent<BoxCollider2D>();
        sizeY = cam.orthographicSize * 2;
        ratio = (float)Screen.width / (float)Screen.height;
        sizeX = sizeY * ratio;
        cambox.size = new Vector2(sizeX, sizeY);
    }
}
