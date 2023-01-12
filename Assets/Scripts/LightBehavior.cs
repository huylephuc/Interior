using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBehavior : MonoBehaviour
{
    public Light myLight;
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            myLight.intensity = 0;
        }   
        else
        { 
            myLight.intensity = 1;
        }
    }
}
