using UnityEngine;

public class WaveSpawnManager : MonoBehaviour
{
    public Wave[] WaveConfigs;
    public WaveController WaveController;

    private int currentWaveIndex = 0;
    private int waveIndex = 0;
    void Start()
    {
        WaveController.ChangeWave(WaveConfigs[0]);
    }

    void Update()
    {
        if (WaveController.IsCompleted())
        {
            currentWaveIndex++;
            if (currentWaveIndex < WaveConfigs.Length)
            {
                WaveController.ChangeWave(WaveConfigs[currentWaveIndex]);
            }
            else
            {
                Debug.Log("Done");
            }
        }
    }
}