using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_melata : MonoBehaviour
{
    public Rigidbody2D enemyRB;
    public float speed;
    bool kanan;
    public Transform cek_dasar;
    public LayerMask layer_dasar_enemy;
    public float panjang_raycast;
    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
        kanan = true;
    }

    // Update is called once per frame
    void Update()
    {
        enemyRB.velocity = new Vector2(speed, enemyRB.velocity.y);

        RaycastHit2D hit_dasar = Physics2D.Raycast(cek_dasar.position, Vector2.down, panjang_raycast,layer_dasar_enemy);

        if(hit_dasar== false)
        {
            if (kanan == true)
            {
                speed *= 1f;
                transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y);
                kanan = false;
            }
            else
            {
                speed *= -1f;
                transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
                kanan = true;
            }
        }
    }
}
