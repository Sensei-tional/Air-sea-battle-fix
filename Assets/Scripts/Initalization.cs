using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initalization : MonoBehaviour
{
    [SerializeField]
    private GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ui);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
