using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transfrom target;
    
    
    
    void Update()
    {
        transform.LookAt(target);
    }
}
