using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
   
    [SerializeField]
    private string mainmenu;

    
    private void OnTriggerEnter2D(Collider2D other)
    {
      
        SceneManager.LoadScene(mainmenu);
    }
}
