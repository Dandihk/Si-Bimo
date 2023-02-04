using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class load_bimo1aja : MonoBehaviour
{
    public GameObject[] player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player");
        Destroy(player[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
