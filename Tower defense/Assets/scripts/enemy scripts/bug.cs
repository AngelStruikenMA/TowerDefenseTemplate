using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Collections;
using UnityEngine;

public class bug: MonoBehaviour
{

    public GameObject GameObject;
    public static event Action BallDead;

    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Playerrr")
        {
            Destroy(gameObject);
            BallDead?.Invoke();
        }

    }
}
