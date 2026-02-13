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

    public void ChangeWave(Wave wave)
    {
        CurrentWave = wave;
        EnemySpawned = 0;
        nextSpawnTime = Time.time;
    }

    public bool IsCompleted()
    {
        return EnemySpawned >= CurrentWave.EnemyCount;
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
