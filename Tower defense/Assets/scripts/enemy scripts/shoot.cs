using System.Collections;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform GunPoint;
    public GameObject BulletPrefab;
    public Transform Target; 
    private bool shooting = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("enemy"))
        {
            Target = other.transform; 
            
            Debug.Log(other.name);

            if (!shooting)
            {
                shooting = true;
                StartCoroutine(Shoot());
            }
        }
    }

    private IEnumerator Shoot()
    {
        while (shooting && Target != null)
        {
           
            GameObject projectile = Instantiate(BulletPrefab, GunPoint.position, Quaternion.identity);

            
            Bullet bulletScript = projectile.GetComponent<Bullet>();
            if (bulletScript != null)
            {
                bulletScript.SetTarget(Target);
            }

            
            yield return new WaitForSeconds(1);
        }

        shooting = false; 
    }
}
