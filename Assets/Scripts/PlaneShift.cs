using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlaneShift : MonoBehaviour
{
    private float spawnPosition;

    [SerializeField]
    private int planeSpeed;

    [SerializeField]
    private GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = this.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnPosition <= -32f)
        {
            MoveRight();
        }
        else if (spawnPosition >= 32f)
        {
            MoveLeft();
        }
    }

    void MoveLeft()
    {
        transform.Translate(Vector3.left * Time.deltaTime * planeSpeed);
    }

    void MoveRight()
    {
        transform.Translate(Vector3.left * Time.deltaTime * planeSpeed);
    }

    private void OnDestroy()
    {
        UpdateScore.score += 50;
        Instantiate(explosion, transform.position, transform.rotation);
    }
}
