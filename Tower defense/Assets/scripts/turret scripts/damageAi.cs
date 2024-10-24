using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageAi : MonoBehaviour
{
    public int DMG;
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        Health health= other.gameObject.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(DMG);
        }
    }
}
