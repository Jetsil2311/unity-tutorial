using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyCubes : MonoBehaviour
{
    private Counter counter;
    
    // Start is called before the first frame update
    void Start()
    {
        counter = FindObjectOfType<Counter>();
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        counter.agregar(1);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
