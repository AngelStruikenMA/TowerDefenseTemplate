using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildTower : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
 

    // Update is called once per frame
    void OnMouseDown()
    {
        if (prefab != null)
        {
            Instantiate(prefab,transform.position,transform.rotation);
        }
       
    }
}
