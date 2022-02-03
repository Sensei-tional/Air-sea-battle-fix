using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneSpawner : MonoBehaviour
{
    private Vector3 spawnPosition;
    private Quaternion spawnRotation;
    private int spawnCount, planeChoice;
    private float spawnTime, planeHeight;
    private float[] planePosition = new float[2] {-32f, 32f};
    private float[] planeRotation = new float[2] {180f, 0f};

    [SerializeField]
    private GameObject planePrefab;

    [SerializeField]
    private float delayTime = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CanSpawn())
        {
            Spawn();
        }
    }

    void Spawn()
    {
        planeChoice = Random.Range(0,2);
        planeHeight = Random.Range(2f,9f);
        spawnPosition = new Vector3(planePosition[planeChoice], planeHeight, 15f);
        spawnRotation = Quaternion.Euler(0f, planeRotation[planeChoice], 0f);
        spawnTime = Time.time + delayTime;
        Instantiate(planePrefab, spawnPosition, spawnRotation);

    }

    private bool CanSpawn()
    {
        return Time.time >= spawnTime;
    }
}
