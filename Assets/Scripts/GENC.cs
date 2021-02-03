using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GENC : MonoBehaviour
{
    public Generatecubes genc;
    public Generatecubes genc1;
    public Generatecubes genc2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void callIns()
    {
        genc.instanciar();
        genc1.instanciar();
        genc2.instanciar();
    }
}
