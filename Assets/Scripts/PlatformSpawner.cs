using System.Collections;
using UnityEngine;
/*
public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    public float spawnInterval = 0.2f;

    void Start()
    {
        SpawnPlatforms(20);
        StartCoroutine(SpawnPlatforms());
    }

    void SpawnPlatforms(int count)
    {
        for (int i = 0; i < count; i++)
        {
            SpawnPlatform();
        }
    }

    void SpawnPlatform()
    {
        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
    }

    IEnumerator SpawnPlatforms()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            SpawnPlatform();
        }
    }
}
*/