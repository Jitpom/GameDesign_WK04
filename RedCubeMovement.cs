using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubeMovement : MonoBehaviour
{
    private Rigidbody pom;

    // Start is called before the first frame update
    void Start()
    {
        pom = GetComponent<Rigidbody>();
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update...Hahaha");
        
    }
}
