using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] healthPrefab;
    [SerializeField] Transform[] spawnPoints;

    //PlayerMove player;
    private float miniDelay = 2f;
    private float maxDelay = 5f;

    private void Start()
    {

        StartCoroutine(spawnHealth());
    }

    IEnumerator spawnHealth()
    {
        while (true)
        {
            float delay = Random.Range(miniDelay, maxDelay);
            int randomDarkSeeds = Random.Range(0, healthPrefab.Length);
            yield return new WaitForSeconds(delay);
            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];
            GameObject healths = Instantiate(healthPrefab[randomDarkSeeds], spawnPoint.position, Quaternion.identity);
            Destroy(healths, 5f);
        }
    }


}
