using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablingandDisablingComponets : MonoBehaviour
{
    private Light myLight;
    
    
    void Start()
    {
        myLight = GetComponet<Light>();
    }


    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }
        
    }
}
