using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] GameObject[] darkSeedsPrefab;
    [SerializeField] Transform[] spawnPoints;

    private float miniDelay = .1f;
    private float maxDelay = 1f;

    private void Start()
    {
        StartCoroutine(spawnEnemies());
    }

    IEnumerator spawnEnemies()
    {
        while (true)
        {
            float delay = Random.Range(miniDelay, maxDelay);
            int randomDarkSeeds = Random.Range(0, darkSeedsPrefab.Length);
            yield return new WaitForSeconds(delay);
            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];
            GameObject spawnDarkSeed = Instantiate(darkSeedsPrefab[randomDarkSeeds], spawnPoint.position, Quaternion.identity);
        }
    }
}
