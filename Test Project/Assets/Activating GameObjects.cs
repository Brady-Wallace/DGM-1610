using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatingGameObjects : MonoBehaviour
{
    
    void Start()
    {
        gameObject.SetActive(false);  
    }
}

public clas CheckState : MonoBehavior
{
    public gameObject myObject;
    
    void Start ()
    {
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hiereachry" + myObject.activeInHierarchy);
    }
}

