using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    private float nextSpawnTime;
    private int randomCloud, cloudChoice;
    private float[] cloudLocation = new float[2] {488f, -429};
    private Vector3 spawnPosition;

    [SerializeField]
    private GameObject[] cloudPrefabs;

    [SerializeField]
    private float spawnDelay = 15;

    // Update is called once per frame
    void Update()
    {
        if (CanSpawn())
        {
            Spawn();
        }        
    }

    private void Spawn()
    {
        cloudChoice = Random.Range(0, 2);
        randomCloud = Random.Range(0, 3);
        spawnPosition = new Vector3(cloudLocation[cloudChoice], Random.Range(90f, 100f), 178f);
        nextSpawnTime = Time.time + spawnDelay;
        Object.Instantiate(cloudPrefabs[randomCloud], spawnPosition, transform.rotation);
    }

    private bool CanSpawn()
    {
        return Time.time >= nextSpawnTime;
    }
}
