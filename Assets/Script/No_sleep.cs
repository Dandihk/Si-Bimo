using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No_sleep : MonoBehaviour
{
    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

}
