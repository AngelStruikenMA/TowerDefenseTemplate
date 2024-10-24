using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;
    public Transform startpoint;
    public Transform[] map;

    private void Awake(){

        main = this;
    }
}