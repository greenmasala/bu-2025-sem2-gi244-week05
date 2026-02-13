using UnityEngine;

public class WaveController : MonoBehaviour
{
    public Wave CurrentWave;
    public Transform[] SpawnPoints;

    int EnemySpawned = 0;
    float nextSpawnTime = 0;
    void Update()
    {
        var t = Time.time; //game time
        if ( t > nextSpawnTime && EnemySpawned < CurrentWave.EnemyCount)
        {
            Spawn();
            EnemySpawned++;
            nextSpawnTime = Time.time + CurrentWave.SpawnInterval;
            Debug.Log(nextSpawnTime);
        }
    }

    void Spawn() //you can right click a function to rename it and all instances of it
    {
        int enemyIndex = Random.Range(0, CurrentWave.EnemyPrefabs.Length);
        int spawnPointIndex = Random.Range(0, SpawnPoints.Length);
        Instantiate(
            CurrentWave.EnemyPrefabs[enemyIndex],
            SpawnPoints[spawnPointIndex].position,
            CurrentWave.EnemyPrefabs[enemyIndex].transform.rotation
        );
    }
}
