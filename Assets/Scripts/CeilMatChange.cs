using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilMatChange : MonoBehaviour
{
    public Material on;
    public Material off;
    void Start()
    {
        GetComponent<Renderer>().material = on;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Renderer>().material = off;
        }
        else
        {
            GetComponent<Renderer>().material = on;
        }
    }
}
