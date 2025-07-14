using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float rotateInput;
    private bool shootCannon;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject cannonMouth;

    [SerializeField]
    private GameObject cannonBall;

    [SerializeField]
    private int rotateSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCannon();

        if (TriggerCannon() && shootCannon == true)
        {
            FireCannon();
            shootCannon = false;
        }
        else if (!TriggerCannon())
        {
            shootCannon = true;
        }
    }

    //Allows cannon to rotate to aim at plans
    void MoveCannon()
    {
        rotateInput = Input.GetAxis("Horizontal");
        player.transform.Rotate(rotateInput * Time.deltaTime * rotateSpeed, 0f, 0f);
    }

    //Fires the cannonball from the mouth of the cannon
    void FireCannon()
    {
        Instantiate(cannonBall, cannonMouth.transform.position, cannonMouth.transform.rotation);
    }

    //Checks if player had fired
    private bool TriggerCannon()
    {
        return Input.GetAxisRaw("Fire1") > 0;
    }
}
