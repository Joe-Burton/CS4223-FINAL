using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject targetPrefab;
    public int numTargets = 5;
    public float spawnRangeX = 4.0f;
    public float spawnRangeY = 4.0f;

    void Start()
    {
        SpawnTargets();
    }

    void SpawnTargets()
    {
        for (int i = 0; i < numTargets; i++)
        {
            float randomX = Random.Range(-spawnRangeX, spawnRangeX);
            float randomY = Random.Range(-spawnRangeY, spawnRangeY);
            Vector3 spawnPosition = new Vector3(randomX, randomY, 0);
            GameObject newTarget = Instantiate(targetPrefab, spawnPosition, Quaternion.identity);
            newTarget.tag = "Target"; // Set the tag of the instantiated target
        }
    }
}