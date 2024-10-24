using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiedetection : MonoBehaviour
{
    public float Range = 15;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("enemy"))
        {
           
        }
    }
}
