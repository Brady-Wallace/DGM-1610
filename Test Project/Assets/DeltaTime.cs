using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTime : MonoBehaviour
{
    public float speed = 8f;
    public float countdown = 3.0f;
    
    
    
    void Update()
    {
        countdown -= TIme.deltaTIme;
        if(countdown <= 0.0f)
            light.enabled = true;
            
        if(Input.GetKey(KeyCode.RightArrow))
            transfrom.position += new Vector3(spped * Time.deltaTime, 0.0f, 0.0f);
     }
}