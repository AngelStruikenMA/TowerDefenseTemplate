using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [Header("References")] 
    [SerializeField] private GameObject[] enemyPrefabs;

    [Header("Attributes")]
    [SerializeField] private int baseEnemies = 8;
    [SerializeField] private float enemiesPerSecond = 4f;
    [SerializeField] private float timeBetweenWaves = 5f;
    [SerializeField] private float difficultyScalingFactor = 0.75f;

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
