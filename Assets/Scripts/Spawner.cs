using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject M1;
    public GameObject M2;

    void Start()
    {
        InvokeRepeating("GenerarMeteorito1",0.5f,0.8f);
        InvokeRepeating("GenerarMeteorito2", 0.3f, 0.6f);
    }

    void GenerarMeteorito1()
    {
        Instantiate(M1, transform.position, Quaternion.identity);
    }

    void GenerarMeteorito2() 
    {
        Instantiate(M2, transform.position, Quaternion.identity);
    }

}
