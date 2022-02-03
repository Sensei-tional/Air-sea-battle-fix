using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudShift : MonoBehaviour
{
    private float startPosition;

    [SerializeField]
    private int cloudSpeed;

    void Start()
    {
        startPosition = this.transform.position.x;
    }

    private void Update()
    {
        if (startPosition <= -429f)
        {
            MoveRight();
        }
        else if (startPosition >= 488f)
        {
            MoveLeft();
        }
    }

    private void MoveLeft()
    {
        transform.Translate(Vector3.left * Time.deltaTime * cloudSpeed);
    }

    private void MoveRight()
    {
        transform.Translate(Vector3.right * Time.deltaTime * cloudSpeed);
    }
}
