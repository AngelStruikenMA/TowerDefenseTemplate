using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class spawner : MonoBehaviour
{
    
    [SerializeField] private GameObject[] enemyPrefabs;

 
    [SerializeField] private int baseEnemies = 8;
    [SerializeField] private float enemiesPerSecond = 4f;
    [SerializeField] private float timeBetweenWaves = 5f;
    [SerializeField] private float difficultyScalingFactor = 0.75f;
          [SerializeField]
    private string mainmenu;

    private int currentWave = 1;
    private float timeSinceLastSpawn;
    private int enemiesAlive;
    private int enemiesLeftToSpawn;
    private bool isSpawning = false;
    private void Start(){
        StartWave();
    }
   private void Update(){
    if(!isSpawning)return;
    timeSinceLastSpawn += Time.deltaTime;
    if (timeSinceLastSpawn >= (1f/ enemiesPerSecond) && enemiesLeftToSpawn > 0){
    SpawnEnemy();
    enemiesLeftToSpawn--;
    enemiesAlive++;
    timeSinceLastSpawn = 0f;
    Debug.Log("Spawn Enemy");}
    else
    {
        enemiesAlive = 0;
        {
        Thread.Sleep(500);
        SceneManager.LoadScene(mainmenu );
        }
    }
   }
   private void StartWave(){
    isSpawning = true;
    enemiesLeftToSpawn = EnemiesPerWave();}
    private void SpawnEnemy(){
        GameObject prefabToSpawn = enemyPrefabs[0];
        Instantiate(prefabToSpawn, LevelManager.main.startpoint.position, Quaternion.identity);
    }

   
    private int EnemiesPerWave(){
        return Mathf.RoundToInt(baseEnemies * Mathf.Pow(currentWave, difficultyScalingFactor));
    }
   
}
