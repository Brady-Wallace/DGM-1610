using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoopsWithArrays : MonoBehaviour
{
    string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
    // Start is called before the first frame update
    void Start()
    {
        foreach (string i in cars)
        {
            Debug.Log(i);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
